using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarafi.Models.DB
{
    public class Customer
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        [Column("CustomerID")]

        public Guid CustomerId { get; set; }
        [StringLength(8)]
        [Unicode(false)]
        public string? CustomerCode { get; set; }
        [StringLength(50)]
        [Required]
        public string? Name { get; set; }
        [Display(Name="Father Name")]
        [StringLength(50)]
        [Required(ErrorMessage ="The father name is required.")]
        public string? Fname { get; set; }
        [StringLength(80)]
        [Display(Name="Tazkera#")]
        [Required]
        public string? TazkeraNumber { get; set; }
        [StringLength(80)]
        [Unicode(false)]
        [Display(Name="Phone#")]
        [Required]
        public string? PhoneNo { get; set; }
        [StringLength(400)]
        public string? Address { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Username { get; set; }
        [Column(TypeName = "datetime")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? EntryDate { get; set; }
        [StringLength(400)]
        public string? Remarks { get; set; }

        [InverseProperty("Customer")]
        public virtual ICollection<Cashbook>? Cashbooks { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<Hawala>? Hawalas { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<Transaction>? Transactions { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<CustomerAccounts>? CustomerAccounts { get; set; }
    }
}
