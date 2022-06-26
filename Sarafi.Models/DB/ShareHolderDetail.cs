using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sarafi.Models.DB
{
    public partial class ShareHolderDetail
    {
        [Key]
        [Column("ShareHolderDetailID")]
        public Guid ShareHolderDetailId { get; set; }
        [Column("ShareHolderID")]
        public byte? ShareHolderId { get; set; }
        [Column("FiscalYearID")]
        public byte? FiscalYearId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? AccountNumber { get; set; }
        [Column("CurrencyID")]
        public byte? CurrencyId { get; set; }
        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Username { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EntryDate { get; set; }
        [StringLength(400)]
        public string? Remarks { get; set; }

        [ForeignKey("CurrencyId")]
        [InverseProperty("ShareHolderDetails")]
        public virtual ZCurrency? Currency { get; set; }
        [ForeignKey("ShareHolderId")]
        [InverseProperty("ShareHolderDetails")]
        public virtual ZShareHolder? ShareHolder { get; set; }
    }
}
