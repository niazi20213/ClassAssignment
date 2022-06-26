using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Sarafi.Models.DB
{
    [Table("Transaction")]
    public partial class Transaction
    {
        [Key]
        [Column("TransactionID")]
        public Guid TransactionId { get; set; }
        [Column("TransactionTypeID")]
        public byte? TransactionTypeId { get; set; }
        [Column("CustomerID")]
        public Guid? CustomerId { get; set; }
        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ExchangeRate { get; set; }
        [Column("CurrencyID")]
        public byte? CurrencyId { get; set; }
        [Column("LocationID")]
        public byte? LocationId { get; set; }
        [Column("FiscalYearID")]
        public byte? FiscalYearId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Entrydate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Username { get; set; }
        [StringLength(400)]
        public string? Remarks { get; set; }

        [ForeignKey("CurrencyId")]
        [InverseProperty("Transactions")]
        public virtual ZCurrency? Currency { get; set; }
        [ForeignKey("CustomerId")]
        [InverseProperty("Transactions")]
        public virtual Customer? Customer { get; set; }
        [ForeignKey("LocationId")]
        [InverseProperty("Transactions")]
        public virtual ZLocation? Location { get; set; }
        [ForeignKey("TransactionTypeId")]
        [InverseProperty("Transactions")]
        public virtual ZTransactionType? TransactionType { get; set; }
    }
}
