using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sarafi.Models;
using Sarafi.Models.DB;
using Sarafi.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarafi.DataAccess.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions): base(dbContextOptions)
        {

        }

        DbSet<ApplicationUser> ApplicationUsers { get; set; }
        DbSet<Cashbook> Cashbooks { get; set; } = null!;
        DbSet<ChartOfAccount> ChartOfAccounts { get; set; } = null!;
        DbSet<Hawala> Hawalas { get; set; } = null!;
        DbSet<ShareHolderDetail> ShareHolderDetails { get; set; } = null!;
        DbSet<ShareHolderDetailsHistory> ShareHolderDetailsHistories { get; set; } = null!;
        DbSet<Transaction> Transactions { get; set; } = null!;
        DbSet<Customer> Customer { get; set; }
        DbSet<UserLocation> UserLocations { get; set; } = null!;
        DbSet<ZCurrency> ZCurrencies { get; set; } = null!;
        DbSet<ZFiscalYear> ZFiscalYears { get; set; } = null!;
        DbSet<ZHawalaStatus> ZHawalaStatuses { get; set; } = null!;
        DbSet<ZLocation> ZLocations { get; set; } = null!;
        DbSet<ZShareHolder> ZShareHolders { get; set; } = null!;
        DbSet<ZTransactionType> ZTransactionTypes { get; set; } = null!;
        DbSet<CustomerAccounts> CustomerAccounts { get; set; }=null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserLocation>().HasKey(k=>new {k.UserId,k.LocationId});
         

        }


    }
}
