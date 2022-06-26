using Microsoft.AspNetCore.Identity;
using Sarafi.Models.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarafi.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        public string FullName { get; set; }

        public virtual ZLocation? Location { get; set; }
    }
}
