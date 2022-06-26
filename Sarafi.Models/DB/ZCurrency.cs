using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sarafi.Models.DB
{
    [Table("zCurrency")]
    public partial class ZCurrency
    {
        public ZCurrency()
        {
            Cashbooks = new HashSet<Cashbook>();
            HawalaCurrencies = new HashSet<Hawala>();
            HawalaRecievedCurrencies = new HashSet<Hawala>();
            ShareHolderDetails = new HashSet<ShareHolderDetail>();
            Transactions = new HashSet<Transaction>();
        }

        [Key]
        [Column("CurrencyID")]
        public byte CurrencyId { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Currency { get; set; }

        [InverseProperty("Currency")]
        public virtual ICollection<Cashbook> Cashbooks { get; set; }
        [InverseProperty("Currency")]
        public virtual ICollection<Hawala> HawalaCurrencies { get; set; }
        [InverseProperty("RecievedCurrency")]
        public virtual ICollection<Hawala> HawalaRecievedCurrencies { get; set; }
        [InverseProperty("Currency")]
        public virtual ICollection<ShareHolderDetail> ShareHolderDetails { get; set; }
        [InverseProperty("Currency")]
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
