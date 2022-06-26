using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sarafi.Models.DB
{
    [Table("zHawalaStatus")]
    public partial class ZHawalaStatus
    {
        public ZHawalaStatus()
        {
            Hawalas = new HashSet<Hawala>();
        }

        [Key]
        [Column("HawalaStatusID")]
        public byte HawalaStatusId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? HawalaStatus { get; set; }

        [InverseProperty("HawalaStatus")]
        public virtual ICollection<Hawala> Hawalas { get; set; }
    }
}
