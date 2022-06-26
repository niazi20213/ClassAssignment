using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sarafi.Models.DB
{
    [Table("zShareHolder")]
    public partial class ZShareHolder
    {
        public ZShareHolder()
        {
            ShareHolderDetails = new HashSet<ShareHolderDetail>();
        }

        [Key]
        [Column("ShareHolderID")]
        public byte ShareHolderId { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? ShareHolder { get; set; }

        [InverseProperty("ShareHolder")]
        public virtual ICollection<ShareHolderDetail> ShareHolderDetails { get; set; }
    }
}
