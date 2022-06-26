using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarafi.Models.DB
{
    public class CustomerAccounts
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CustomerAccountID { get; set; }
        [Required]
        public string? CustomerAccount { get; set; }
        [Column(TypeName ="Money")]
        public decimal? Balance { get; set; }

        [StringLength(8)]
        [Unicode(false)]
        public string? CustomerCode { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? LastUpdatedDate { get; set; }=DateTime.Now;
        [Column(TypeName = "datetime")]
        public DateTime? Entrydate { get; set; } = DateTime.Now;
        [StringLength(50)]
        [Unicode(false)]
        public string? Username { get; set; }
        [StringLength(400)]
        public string? Remarks { get; set; }
        public virtual Customer? Customer { get; set; }


    }
}
