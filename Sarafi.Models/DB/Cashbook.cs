using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Sarafi.Models.DB
{
    [Table("Cashbook")]
    public partial class Cashbook
    {
        [Key]
        [Column("CashbookID")]
        public Guid CashbookId { get; set; }
        [StringLength(50)]
        public string? ReferenceNumber { get; set; }
        [StringLength(250)]
        public string? Description { get; set; }
        [Column("CustomerID")]
        public Guid? CustomerId { get; set; }
        [Column("TransactionTypeID")]
        public byte? TransactionTypeId { get; set; }
        [Column("LocationID")]
        public byte? LocationId { get; set; }
        [Column("CurrencyID")]
        public byte? CurrencyId { get; set; }
        [Column("ShareHolderID")]
        public byte? ShareHolderId { get; set; }
        [Column(TypeName = "money")]
        public decimal? AmountReceived { get; set; }
        [Column(TypeName = "money")]
        public decimal? AmountTransferred { get; set; }
        public int? SerialNo { get; set; }
        [Column("FiscalYearID")]
        public byte? FiscalYearId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EntryDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Username { get; set; }
        [StringLength(400)]
        public string? Remarks { get; set; }

        [ForeignKey("CurrencyId")]
        [InverseProperty("Cashbooks")]
        public virtual ZCurrency? Currency { get; set; }
        [ForeignKey("CustomerId")]
        [InverseProperty("Cashbooks")]
        public virtual Customer? Customer { get; set; }
        [ForeignKey("FiscalYearId")]
        [InverseProperty("Cashbooks")]
        public virtual ZFiscalYear? FiscalYear { get; set; }
        [ForeignKey("LocationId")]
        [InverseProperty("Cashbooks")]
        public virtual ZLocation? Location { get; set; }
        [ForeignKey("TransactionTypeId")]
        [InverseProperty("Cashbooks")]
        public virtual ZTransactionType? TransactionType { get; set; }
    }
}
