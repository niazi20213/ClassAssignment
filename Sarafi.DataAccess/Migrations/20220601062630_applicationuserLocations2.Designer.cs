﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sarafi.DataAccess.Data;

#nullable disable

namespace Sarafi.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220601062630_applicationuserLocations2")]
    partial class applicationuserLocations2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Sarafi.Models.DB.Cashbook", b =>
                {
                    b.Property<Guid>("CashbookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CashbookID");

                    b.Property<decimal?>("AmountReceived")
                        .HasColumnType("money");

                    b.Property<decimal?>("AmountTransferred")
                        .HasColumnType("money");

                    b.Property<byte?>("CurrencyId")
                        .HasColumnType("tinyint")
                        .HasColumnName("CurrencyID");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CustomerID");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("EntryDate")
                        .HasColumnType("datetime");

                    b.Property<byte?>("FiscalYearId")
                        .HasColumnType("tinyint")
                        .HasColumnName("FiscalYearID");

                    b.Property<byte?>("LocationId")
                        .HasColumnType("tinyint")
                        .HasColumnName("LocationID");

                    b.Property<string>("ReferenceNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Remarks")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<int?>("SerialNo")
                        .HasColumnType("int");

                    b.Property<byte?>("ShareHolderId")
                        .HasColumnType("tinyint")
                        .HasColumnName("ShareHolderID");

                    b.Property<byte?>("TransactionTypeId")
                        .HasColumnType("tinyint")
                        .HasColumnName("TransactionTypeID");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("CashbookId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("FiscalYearId");

                    b.HasIndex("LocationId");

                    b.HasIndex("TransactionTypeId");

                    b.ToTable("Cashbook");
                });

            modelBuilder.Entity("Sarafi.Models.DB.ChartOfAccount", b =>
                {
                    b.Property<Guid>("ChartOfAccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ChartOfAccountID");

                    b.Property<string>("ChartOfAccountCode")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ChartOfAccountHead")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("ChartOfAccountShortMemo")
                        .HasMaxLength(800)
                        .IsUnicode(false)
                        .HasColumnType("varchar(800)");

                    b.Property<DateTime?>("Entrydate")
                        .HasColumnType("datetime");

                    b.Property<string>("Remark")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("ChartOfAccountId");

                    b.ToTable("ChartOfAccount");
                });

            modelBuilder.Entity("Sarafi.Models.DB.Customer", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CustomerID");

                    b.Property<string>("Address")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("CustomerCode")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)");

                    b.Property<DateTime?>("EntryDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Remarks")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("TazkeraNumber")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Sarafi.Models.DB.CustomerAccounts", b =>
                {
                    b.Property<Guid>("CustomerAccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Balance")
                        .HasColumnType("Money");

                    b.Property<string>("CustomerAccount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerCode")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Entrydate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Remarks")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("CustomerAccountID");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerAccounts");
                });

            modelBuilder.Entity("Sarafi.Models.DB.Hawala", b =>
                {
                    b.Property<Guid>("HawalaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("HawalaID");

                    b.Property<decimal?>("Amount")
                        .HasColumnType("money");

                    b.Property<byte?>("CurrencyId")
                        .HasColumnType("tinyint")
                        .HasColumnName("CurrencyID");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CustomerID");

                    b.Property<DateTime?>("Entrydate")
                        .HasColumnType("datetime");

                    b.Property<decimal?>("ExchangeRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<byte?>("FiscalYearId")
                        .HasColumnType("tinyint")
                        .HasColumnName("FiscalYearID");

                    b.Property<string>("HawalaCode")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)");

                    b.Property<byte?>("HawalaStatusId")
                        .HasColumnType("tinyint")
                        .HasColumnName("HawalaStatusID");

                    b.Property<byte?>("LocationId")
                        .HasColumnType("tinyint")
                        .HasColumnName("LocationID");

                    b.Property<byte?>("LocationtoId")
                        .HasColumnType("tinyint")
                        .HasColumnName("LocationtoID");

                    b.Property<DateTime?>("ReceivedDate")
                        .HasColumnType("datetime");

                    b.Property<byte?>("RecievedCurrencyId")
                        .HasColumnType("tinyint")
                        .HasColumnName("RecievedCurrencyID");

                    b.Property<string>("Referencesto")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Remarks")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<DateTime?>("SubmissionDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("HawalaId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("FiscalYearId");

                    b.HasIndex("HawalaStatusId");

                    b.HasIndex("LocationId");

                    b.HasIndex("LocationtoId");

                    b.HasIndex("RecievedCurrencyId");

                    b.ToTable("Hawala");
                });

            modelBuilder.Entity("Sarafi.Models.DB.ShareHolderDetail", b =>
                {
                    b.Property<Guid>("ShareHolderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ShareHolderDetailID");

                    b.Property<string>("AccountNumber")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal?>("Amount")
                        .HasColumnType("money");

                    b.Property<byte?>("CurrencyId")
                        .HasColumnType("tinyint")
                        .HasColumnName("CurrencyID");

                    b.Property<DateTime?>("EntryDate")
                        .HasColumnType("datetime");

                    b.Property<byte?>("FiscalYearId")
                        .HasColumnType("tinyint")
                        .HasColumnName("FiscalYearID");

                    b.Property<string>("Remarks")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<byte?>("ShareHolderId")
                        .HasColumnType("tinyint")
                        .HasColumnName("ShareHolderID");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("ShareHolderDetailId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("ShareHolderId");

                    b.ToTable("ShareHolderDetails");
                });

            modelBuilder.Entity("Sarafi.Models.DB.ShareHolderDetailsHistory", b =>
                {
                    b.Property<Guid>("ShareHolderDetailHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ShareHolderDetailHistoryID");

                    b.Property<string>("AccountNumber")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal?>("Amount")
                        .HasColumnType("money");

                    b.Property<byte?>("CurrencyId")
                        .HasColumnType("tinyint")
                        .HasColumnName("CurrencyID");

                    b.Property<DateTime?>("EntryDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Remarks")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<Guid?>("ShareHolderDetailId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ShareHolderDetailID");

                    b.Property<byte?>("ShareHolderId")
                        .HasColumnType("tinyint")
                        .HasColumnName("ShareHolderID");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("ShareHolderDetailHistoryId");

                    b.ToTable("ShareHolderDetailsHistory");
                });

            modelBuilder.Entity("Sarafi.Models.DB.Transaction", b =>
                {
                    b.Property<Guid>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("TransactionID");

                    b.Property<decimal?>("Amount")
                        .HasColumnType("money");

                    b.Property<byte?>("CurrencyId")
                        .HasColumnType("tinyint")
                        .HasColumnName("CurrencyID");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CustomerID");

                    b.Property<DateTime?>("Entrydate")
                        .HasColumnType("datetime");

                    b.Property<decimal?>("ExchangeRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<byte?>("FiscalYearId")
                        .HasColumnType("tinyint")
                        .HasColumnName("FiscalYearID");

                    b.Property<byte?>("LocationId")
                        .HasColumnType("tinyint")
                        .HasColumnName("LocationID");

                    b.Property<string>("Remarks")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<byte?>("TransactionTypeId")
                        .HasColumnType("tinyint")
                        .HasColumnName("TransactionTypeID");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("TransactionId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LocationId");

                    b.HasIndex("TransactionTypeId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("Sarafi.Models.DB.UserLocation", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UserID");

                    b.Property<byte>("LocationId")
                        .HasColumnType("tinyint")
                        .HasColumnName("LocationID");

                    b.HasKey("UserId", "LocationId");

                    b.ToTable("UserLocation");
                });

            modelBuilder.Entity("Sarafi.Models.DB.ZCurrency", b =>
                {
                    b.Property<byte>("CurrencyId")
                        .HasColumnType("tinyint")
                        .HasColumnName("CurrencyID");

                    b.Property<string>("Currency")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("CurrencyId");

                    b.ToTable("zCurrency");
                });

            modelBuilder.Entity("Sarafi.Models.DB.ZFiscalYear", b =>
                {
                    b.Property<byte>("FiscalYearId")
                        .HasColumnType("tinyint")
                        .HasColumnName("FiscalYearID");

                    b.Property<int?>("FiscalYear")
                        .HasColumnType("int");

                    b.Property<DateTime?>("GeorgianEndDate")
                        .HasColumnType("smalldatetime");

                    b.Property<DateTime?>("GeorgianStartDate")
                        .HasColumnType("smalldatetime");

                    b.Property<short?>("GeorgianYear")
                        .HasColumnType("smallint");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("isActive");

                    b.Property<DateTime?>("ParsianEndDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("ParsianStartDate")
                        .HasColumnType("datetime");

                    b.HasKey("FiscalYearId");

                    b.ToTable("zFiscalYear");
                });

            modelBuilder.Entity("Sarafi.Models.DB.ZHawalaStatus", b =>
                {
                    b.Property<byte>("HawalaStatusId")
                        .HasColumnType("tinyint")
                        .HasColumnName("HawalaStatusID");

                    b.Property<string>("HawalaStatus")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("HawalaStatusId");

                    b.ToTable("zHawalaStatus");
                });

            modelBuilder.Entity("Sarafi.Models.DB.ZLocation", b =>
                {
                    b.Property<byte>("LocationId")
                        .HasColumnType("tinyint")
                        .HasColumnName("LocationID");

                    b.Property<string>("Location")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("LocationId");

                    b.ToTable("zLocation");
                });

            modelBuilder.Entity("Sarafi.Models.DB.ZShareHolder", b =>
                {
                    b.Property<byte>("ShareHolderId")
                        .HasColumnType("tinyint")
                        .HasColumnName("ShareHolderID");

                    b.Property<string>("ShareHolder")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("ShareHolderId");

                    b.ToTable("zShareHolder");
                });

            modelBuilder.Entity("Sarafi.Models.DB.ZTransactionType", b =>
                {
                    b.Property<byte>("TransactionTypeId")
                        .HasColumnType("tinyint")
                        .HasColumnName("TransactionTypeID");

                    b.Property<DateTime?>("EntryDate")
                        .HasColumnType("datetime");

                    b.Property<string>("TransactionType")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("TransactionTypeId");

                    b.ToTable("zTransactionType");
                });

            modelBuilder.Entity("Sarafi.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("LocationId")
                        .HasColumnType("tinyint");

                    b.HasIndex("LocationId");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sarafi.Models.DB.Cashbook", b =>
                {
                    b.HasOne("Sarafi.Models.DB.ZCurrency", "Currency")
                        .WithMany("Cashbooks")
                        .HasForeignKey("CurrencyId");

                    b.HasOne("Sarafi.Models.DB.Customer", "Customer")
                        .WithMany("Cashbooks")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Sarafi.Models.DB.ZFiscalYear", "FiscalYear")
                        .WithMany("Cashbooks")
                        .HasForeignKey("FiscalYearId");

                    b.HasOne("Sarafi.Models.DB.ZLocation", "Location")
                        .WithMany("Cashbooks")
                        .HasForeignKey("LocationId");

                    b.HasOne("Sarafi.Models.DB.ZTransactionType", "TransactionType")
                        .WithMany("Cashbooks")
                        .HasForeignKey("TransactionTypeId");

                    b.Navigation("Currency");

                    b.Navigation("Customer");

                    b.Navigation("FiscalYear");

                    b.Navigation("Location");

                    b.Navigation("TransactionType");
                });

            modelBuilder.Entity("Sarafi.Models.DB.CustomerAccounts", b =>
                {
                    b.HasOne("Sarafi.Models.DB.Customer", "Customer")
                        .WithMany("CustomerAccounts")
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Sarafi.Models.DB.Hawala", b =>
                {
                    b.HasOne("Sarafi.Models.DB.ZCurrency", "Currency")
                        .WithMany("HawalaCurrencies")
                        .HasForeignKey("CurrencyId");

                    b.HasOne("Sarafi.Models.DB.Customer", "Customer")
                        .WithMany("Hawalas")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Sarafi.Models.DB.ZFiscalYear", "FiscalYear")
                        .WithMany("Hawalas")
                        .HasForeignKey("FiscalYearId");

                    b.HasOne("Sarafi.Models.DB.ZHawalaStatus", "HawalaStatus")
                        .WithMany("Hawalas")
                        .HasForeignKey("HawalaStatusId");

                    b.HasOne("Sarafi.Models.DB.ZLocation", "Location")
                        .WithMany("HawalaLocations")
                        .HasForeignKey("LocationId");

                    b.HasOne("Sarafi.Models.DB.ZLocation", "Locationto")
                        .WithMany("HawalaLocationtos")
                        .HasForeignKey("LocationtoId");

                    b.HasOne("Sarafi.Models.DB.ZCurrency", "RecievedCurrency")
                        .WithMany("HawalaRecievedCurrencies")
                        .HasForeignKey("RecievedCurrencyId");

                    b.Navigation("Currency");

                    b.Navigation("Customer");

                    b.Navigation("FiscalYear");

                    b.Navigation("HawalaStatus");

                    b.Navigation("Location");

                    b.Navigation("Locationto");

                    b.Navigation("RecievedCurrency");
                });

            modelBuilder.Entity("Sarafi.Models.DB.ShareHolderDetail", b =>
                {
                    b.HasOne("Sarafi.Models.DB.ZCurrency", "Currency")
                        .WithMany("ShareHolderDetails")
                        .HasForeignKey("CurrencyId");

                    b.HasOne("Sarafi.Models.DB.ZShareHolder", "ShareHolder")
                        .WithMany("ShareHolderDetails")
                        .HasForeignKey("ShareHolderId");

                    b.Navigation("Currency");

                    b.Navigation("ShareHolder");
                });

            modelBuilder.Entity("Sarafi.Models.DB.Transaction", b =>
                {
                    b.HasOne("Sarafi.Models.DB.ZCurrency", "Currency")
                        .WithMany("Transactions")
                        .HasForeignKey("CurrencyId");

                    b.HasOne("Sarafi.Models.DB.Customer", "Customer")
                        .WithMany("Transactions")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Sarafi.Models.DB.ZLocation", "Location")
                        .WithMany("Transactions")
                        .HasForeignKey("LocationId");

                    b.HasOne("Sarafi.Models.DB.ZTransactionType", "TransactionType")
                        .WithMany("Transactions")
                        .HasForeignKey("TransactionTypeId");

                    b.Navigation("Currency");

                    b.Navigation("Customer");

                    b.Navigation("Location");

                    b.Navigation("TransactionType");
                });

            modelBuilder.Entity("Sarafi.Models.ApplicationUser", b =>
                {
                    b.HasOne("Sarafi.Models.DB.ZLocation", "Location")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Sarafi.Models.DB.Customer", b =>
                {
                    b.Navigation("Cashbooks");

                    b.Navigation("CustomerAccounts");

                    b.Navigation("Hawalas");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Sarafi.Models.DB.ZCurrency", b =>
                {
                    b.Navigation("Cashbooks");

                    b.Navigation("HawalaCurrencies");

                    b.Navigation("HawalaRecievedCurrencies");

                    b.Navigation("ShareHolderDetails");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Sarafi.Models.DB.ZFiscalYear", b =>
                {
                    b.Navigation("Cashbooks");

                    b.Navigation("Hawalas");
                });

            modelBuilder.Entity("Sarafi.Models.DB.ZHawalaStatus", b =>
                {
                    b.Navigation("Hawalas");
                });

            modelBuilder.Entity("Sarafi.Models.DB.ZLocation", b =>
                {
                    b.Navigation("ApplicationUsers");

                    b.Navigation("Cashbooks");

                    b.Navigation("HawalaLocations");

                    b.Navigation("HawalaLocationtos");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Sarafi.Models.DB.ZShareHolder", b =>
                {
                    b.Navigation("ShareHolderDetails");
                });

            modelBuilder.Entity("Sarafi.Models.DB.ZTransactionType", b =>
                {
                    b.Navigation("Cashbooks");

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
