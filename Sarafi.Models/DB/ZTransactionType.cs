using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sarafi.Models.DB
{
    [Table("zTransactionType")]
    public partial class ZTransactionType
    {
        public ZTransactionType()
        {
            Cashbooks = new HashSet<Cashbook>();
            Transactions = new HashSet<Transaction>();
        }

        [Key]
        [Column("TransactionTypeID")]
        public byte TransactionTypeId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? TransactionType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EntryDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Username { get; set; }

        [InverseProperty("TransactionType")]
        public virtual ICollection<Cashbook> Cashbooks { get; set; }
        [InverseProperty("TransactionType")]
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
