using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sarafi.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChartOfAccount",
                columns: table => new
                {
                    ChartOfAccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChartOfAccountCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ChartOfAccountHead = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ChartOfAccountShortMemo = table.Column<string>(type: "varchar(800)", unicode: false, maxLength: 800, nullable: true),
                    Username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Entrydate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChartOfAccount", x => x.ChartOfAccountID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerCode = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TazkeraNumber = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    PhoneNo = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "ShareHolderDetailsHistory",
                columns: table => new
                {
                    ShareHolderDetailHistoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShareHolderDetailID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ShareHolderID = table.Column<byte>(type: "tinyint", nullable: true),
                    AccountNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CurrencyID = table.Column<byte>(type: "tinyint", nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: true),
                    Username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShareHolderDetailsHistory", x => x.ShareHolderDetailHistoryID);
                });

            migrationBuilder.CreateTable(
                name: "UserLocation",
                columns: table => new
                {
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationID = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLocation", x => new { x.UserID, x.LocationID });
                });

            migrationBuilder.CreateTable(
                name: "zCurrency",
                columns: table => new
                {
                    CurrencyID = table.Column<byte>(type: "tinyint", nullable: false),
                    Currency = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zCurrency", x => x.CurrencyID);
                });

            migrationBuilder.CreateTable(
                name: "zFiscalYear",
                columns: table => new
                {
                    FiscalYearID = table.Column<byte>(type: "tinyint", nullable: false),
                    FiscalYear = table.Column<int>(type: "int", nullable: true),
                    GeorgianStartDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    GeorgianEndDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    GeorgianYear = table.Column<short>(type: "smallint", nullable: true),
                    ParsianStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ParsianEndDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zFiscalYear", x => x.FiscalYearID);
                });

            migrationBuilder.CreateTable(
                name: "zHawalaStatus",
                columns: table => new
                {
                    HawalaStatusID = table.Column<byte>(type: "tinyint", nullable: false),
                    HawalaStatus = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zHawalaStatus", x => x.HawalaStatusID);
                });

            migrationBuilder.CreateTable(
                name: "zLocation",
                columns: table => new
                {
                    LocationID = table.Column<byte>(type: "tinyint", nullable: false),
                    Location = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zLocation", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "zShareHolder",
                columns: table => new
                {
                    ShareHolderID = table.Column<byte>(type: "tinyint", nullable: false),
                    ShareHolder = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zShareHolder", x => x.ShareHolderID);
                });

            migrationBuilder.CreateTable(
                name: "zTransactionType",
                columns: table => new
                {
                    TransactionTypeID = table.Column<byte>(type: "tinyint", nullable: false),
                    TransactionType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zTransactionType", x => x.TransactionTypeID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAccounts",
                columns: table => new
                {
                    CustomerAccountID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Balance = table.Column<decimal>(type: "Money", nullable: true),
                    CustomerCode = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Entrydate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAccounts", x => x.CustomerAccountID);
                    table.ForeignKey(
                        name: "FK_CustomerAccounts_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                });

            migrationBuilder.CreateTable(
                name: "Hawala",
                columns: table => new
                {
                    HawalaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Referencesto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ReceivedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CurrencyID = table.Column<byte>(type: "tinyint", nullable: true),
                    RecievedCurrencyID = table.Column<byte>(type: "tinyint", nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LocationID = table.Column<byte>(type: "tinyint", nullable: true),
                    LocationtoID = table.Column<byte>(type: "tinyint", nullable: true),
                    HawalaStatusID = table.Column<byte>(type: "tinyint", nullable: true),
                    FiscalYearID = table.Column<byte>(type: "tinyint", nullable: true),
                    HawalaCode = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    Entrydate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hawala", x => x.HawalaID);
                    table.ForeignKey(
                        name: "FK_Hawala_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_Hawala_zCurrency_CurrencyID",
                        column: x => x.CurrencyID,
                        principalTable: "zCurrency",
                        principalColumn: "CurrencyID");
                    table.ForeignKey(
                        name: "FK_Hawala_zCurrency_RecievedCurrencyID",
                        column: x => x.RecievedCurrencyID,
                        principalTable: "zCurrency",
                        principalColumn: "CurrencyID");
                    table.ForeignKey(
                        name: "FK_Hawala_zFiscalYear_FiscalYearID",
                        column: x => x.FiscalYearID,
                        principalTable: "zFiscalYear",
                        principalColumn: "FiscalYearID");
                    table.ForeignKey(
                        name: "FK_Hawala_zHawalaStatus_HawalaStatusID",
                        column: x => x.HawalaStatusID,
                        principalTable: "zHawalaStatus",
                        principalColumn: "HawalaStatusID");
                    table.ForeignKey(
                        name: "FK_Hawala_zLocation_LocationID",
                        column: x => x.LocationID,
                        principalTable: "zLocation",
                        principalColumn: "LocationID");
                    table.ForeignKey(
                        name: "FK_Hawala_zLocation_LocationtoID",
                        column: x => x.LocationtoID,
                        principalTable: "zLocation",
                        principalColumn: "LocationID");
                });

            migrationBuilder.CreateTable(
                name: "ShareHolderDetails",
                columns: table => new
                {
                    ShareHolderDetailID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShareHolderID = table.Column<byte>(type: "tinyint", nullable: true),
                    FiscalYearID = table.Column<byte>(type: "tinyint", nullable: true),
                    AccountNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CurrencyID = table.Column<byte>(type: "tinyint", nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: true),
                    Username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShareHolderDetails", x => x.ShareHolderDetailID);
                    table.ForeignKey(
                        name: "FK_ShareHolderDetails_zCurrency_CurrencyID",
                        column: x => x.CurrencyID,
                        principalTable: "zCurrency",
                        principalColumn: "CurrencyID");
                    table.ForeignKey(
                        name: "FK_ShareHolderDetails_zShareHolder_ShareHolderID",
                        column: x => x.ShareHolderID,
                        principalTable: "zShareHolder",
                        principalColumn: "ShareHolderID");
                });

            migrationBuilder.CreateTable(
                name: "Cashbook",
                columns: table => new
                {
                    CashbookID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransactionTypeID = table.Column<byte>(type: "tinyint", nullable: true),
                    LocationID = table.Column<byte>(type: "tinyint", nullable: true),
                    CurrencyID = table.Column<byte>(type: "tinyint", nullable: true),
                    ShareHolderID = table.Column<byte>(type: "tinyint", nullable: true),
                    AmountReceived = table.Column<decimal>(type: "money", nullable: true),
                    AmountTransferred = table.Column<decimal>(type: "money", nullable: true),
                    SerialNo = table.Column<int>(type: "int", nullable: true),
                    FiscalYearID = table.Column<byte>(type: "tinyint", nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cashbook", x => x.CashbookID);
                    table.ForeignKey(
                        name: "FK_Cashbook_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_Cashbook_zCurrency_CurrencyID",
                        column: x => x.CurrencyID,
                        principalTable: "zCurrency",
                        principalColumn: "CurrencyID");
                    table.ForeignKey(
                        name: "FK_Cashbook_zFiscalYear_FiscalYearID",
                        column: x => x.FiscalYearID,
                        principalTable: "zFiscalYear",
                        principalColumn: "FiscalYearID");
                    table.ForeignKey(
                        name: "FK_Cashbook_zLocation_LocationID",
                        column: x => x.LocationID,
                        principalTable: "zLocation",
                        principalColumn: "LocationID");
                    table.ForeignKey(
                        name: "FK_Cashbook_zTransactionType_TransactionTypeID",
                        column: x => x.TransactionTypeID,
                        principalTable: "zTransactionType",
                        principalColumn: "TransactionTypeID");
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    TransactionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionTypeID = table.Column<byte>(type: "tinyint", nullable: true),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CurrencyID = table.Column<byte>(type: "tinyint", nullable: true),
                    LocationID = table.Column<byte>(type: "tinyint", nullable: true),
                    FiscalYearID = table.Column<byte>(type: "tinyint", nullable: true),
                    Entrydate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_Transaction_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_Transaction_zCurrency_CurrencyID",
                        column: x => x.CurrencyID,
                        principalTable: "zCurrency",
                        principalColumn: "CurrencyID");
                    table.ForeignKey(
                        name: "FK_Transaction_zLocation_LocationID",
                        column: x => x.LocationID,
                        principalTable: "zLocation",
                        principalColumn: "LocationID");
                    table.ForeignKey(
                        name: "FK_Transaction_zTransactionType_TransactionTypeID",
                        column: x => x.TransactionTypeID,
                        principalTable: "zTransactionType",
                        principalColumn: "TransactionTypeID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cashbook_CurrencyID",
                table: "Cashbook",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_Cashbook_CustomerID",
                table: "Cashbook",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Cashbook_FiscalYearID",
                table: "Cashbook",
                column: "FiscalYearID");

            migrationBuilder.CreateIndex(
                name: "IX_Cashbook_LocationID",
                table: "Cashbook",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Cashbook_TransactionTypeID",
                table: "Cashbook",
                column: "TransactionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccounts_CustomerId",
                table: "CustomerAccounts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Hawala_CurrencyID",
                table: "Hawala",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_Hawala_CustomerID",
                table: "Hawala",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Hawala_FiscalYearID",
                table: "Hawala",
                column: "FiscalYearID");

            migrationBuilder.CreateIndex(
                name: "IX_Hawala_HawalaStatusID",
                table: "Hawala",
                column: "HawalaStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Hawala_LocationID",
                table: "Hawala",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Hawala_LocationtoID",
                table: "Hawala",
                column: "LocationtoID");

            migrationBuilder.CreateIndex(
                name: "IX_Hawala_RecievedCurrencyID",
                table: "Hawala",
                column: "RecievedCurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_ShareHolderDetails_CurrencyID",
                table: "ShareHolderDetails",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_ShareHolderDetails_ShareHolderID",
                table: "ShareHolderDetails",
                column: "ShareHolderID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CurrencyID",
                table: "Transaction",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transaction",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_LocationID",
                table: "Transaction",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_TransactionTypeID",
                table: "Transaction",
                column: "TransactionTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Cashbook");

            migrationBuilder.DropTable(
                name: "ChartOfAccount");

            migrationBuilder.DropTable(
                name: "CustomerAccounts");

            migrationBuilder.DropTable(
                name: "Hawala");

            migrationBuilder.DropTable(
                name: "ShareHolderDetails");

            migrationBuilder.DropTable(
                name: "ShareHolderDetailsHistory");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "UserLocation");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "zFiscalYear");

            migrationBuilder.DropTable(
                name: "zHawalaStatus");

            migrationBuilder.DropTable(
                name: "zShareHolder");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "zCurrency");

            migrationBuilder.DropTable(
                name: "zLocation");

            migrationBuilder.DropTable(
                name: "zTransactionType");
        }
    }
}
