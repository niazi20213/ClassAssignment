using Microsoft.EntityFrameworkCore;
using Sarafi.DataAccess.Data;
using Microsoft.AspNetCore.Identity;
using Sarafi.Utility;
using Microsoft.AspNetCore.Identity.UI.Services;
using Sarafi.DataAccess.Repository;
using Sarafi.DataAccess;
using Sarafi.DataAccess.Repository.IRepository;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddIdentity<IdentityUser,IdentityRole>().AddDefaultTokenProviders()
    .AddEntityFrameworkStores<ApplicationDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
string connectionstring = builder.Configuration.GetConnectionString("DefaultConnectionString");
builder.Services.AddDbContext<ApplicationDbContext>(option=>option.UseSqlServer(connectionstring));

//set connection string.
SD.Connectionstring = connectionstring;

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddSingleton<IEmailSender, EmailSender>();

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.ConfigureApplicationCookie(option =>
{
    option.LoginPath = $"/Identity/Account/Login";
    option.LogoutPath = $"/Identity/Account/Logout";
    option.AccessDeniedPath = $"/Identity/Account/AccessDenied";
});

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(option =>
{
    option.IdleTimeout = TimeSpan.FromMinutes(100);
    option.Cookie.HttpOnly = true;
    option.Cookie.IsEssential = true;

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();
app.MapRazorPages();
app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{area=Changer}/{controller=Home}/{action=Index}/{id?}");

app.Run();
