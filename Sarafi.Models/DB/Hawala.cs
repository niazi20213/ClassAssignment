using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sarafi.Models.DB
{
    [Table("Hawala")]
    public partial class Hawala
    {
        [Key]
        [Column("HawalaID")]
        public Guid HawalaId { get; set; }
        [Column("CustomerID")]
        public Guid? CustomerId { get; set; }
        [StringLength(100)]
        public string? Referencesto { get; set; }
        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SubmissionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceivedDate { get; set; }
        [Column("CurrencyID")]
        public byte? CurrencyId { get; set; }
        [Column("RecievedCurrencyID")]
        public byte? RecievedCurrencyId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ExchangeRate { get; set; }
        [Column("LocationID")]
        public byte? LocationId { get; set; }
        [Column("LocationtoID")]
        public byte? LocationtoId { get; set; }
        [Column("HawalaStatusID")]
        public byte? HawalaStatusId { get; set; }
        [Column("FiscalYearID")]
        public byte? FiscalYearId { get; set; }
        [StringLength(12)]
        [Unicode(false)]
        public string? HawalaCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Entrydate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Username { get; set; }
        [StringLength(400)]
        public string? Remarks { get; set; }

        [ForeignKey("CurrencyId")]
        [InverseProperty("HawalaCurrencies")]
        public virtual ZCurrency? Currency { get; set; }
        [ForeignKey("CustomerId")]
        [InverseProperty("Hawalas")]
        public virtual Customer? Customer { get; set; }
        [ForeignKey("FiscalYearId")]
        [InverseProperty("Hawalas")]
        public virtual ZFiscalYear? FiscalYear { get; set; }
        [ForeignKey("HawalaStatusId")]
        [InverseProperty("Hawalas")]
        public virtual ZHawalaStatus? HawalaStatus { get; set; }
        [ForeignKey("LocationId")]
        [InverseProperty("HawalaLocations")]
        public virtual ZLocation? Location { get; set; }
        [ForeignKey("LocationtoId")]
        [InverseProperty("HawalaLocationtos")]
        public virtual ZLocation? Locationto { get; set; }
        [ForeignKey("RecievedCurrencyId")]
        [InverseProperty("HawalaRecievedCurrencies")]
        public virtual ZCurrency? RecievedCurrency { get; set; }
    }
}
