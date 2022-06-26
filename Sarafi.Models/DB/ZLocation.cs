using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sarafi.Models.DB
{
    [Table("zLocation")]
    public partial class ZLocation
    {
        public ZLocation()
        {
            Cashbooks = new HashSet<Cashbook>();
            HawalaLocations = new HashSet<Hawala>();
            HawalaLocationtos = new HashSet<Hawala>();
            Transactions = new HashSet<Transaction>();
        }

        [Key]
        [Column("LocationID")]
        public byte LocationId { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Location { get; set; }

        [InverseProperty("Location")]
        public virtual ICollection<Cashbook> Cashbooks { get; set; }
        [InverseProperty("Location")]
        public virtual ICollection<Hawala> HawalaLocations { get; set; }
        [InverseProperty("Locationto")]
        public virtual ICollection<Hawala> HawalaLocationtos { get; set; }
        [InverseProperty("Location")]
        public virtual ICollection<Transaction> Transactions { get; set; }

        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}
