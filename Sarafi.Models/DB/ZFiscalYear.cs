using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sarafi.Models.DB
{
    [Table("zFiscalYear")]
    public partial class ZFiscalYear
    {
        public ZFiscalYear()
        {
            Cashbooks = new HashSet<Cashbook>();
            Hawalas = new HashSet<Hawala>();
        }

        [Key]
        [Column("FiscalYearID")]
        public byte FiscalYearId { get; set; }
        public int? FiscalYear { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? GeorgianStartDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? GeorgianEndDate { get; set; }
        [Column("isActive")]
        public bool? IsActive { get; set; }
        public short? GeorgianYear { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ParsianStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ParsianEndDate { get; set; }

        [InverseProperty("FiscalYear")]
        public virtual ICollection<Cashbook> Cashbooks { get; set; }
        [InverseProperty("FiscalYear")]
        public virtual ICollection<Hawala> Hawalas { get; set; }
    }
}
