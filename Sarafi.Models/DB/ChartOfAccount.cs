using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sarafi.Models.DB
{
    [Table("ChartOfAccount")]
    public partial class ChartOfAccount
    {
        [Key]
        [Column("ChartOfAccountID")]
        public Guid ChartOfAccountId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? ChartOfAccountCode { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? ChartOfAccountHead { get; set; }
        [StringLength(800)]
        [Unicode(false)]
        public string? ChartOfAccountShortMemo { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Username { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Entrydate { get; set; }
        [StringLength(500)]
        public string? Remark { get; set; }
    }
}
