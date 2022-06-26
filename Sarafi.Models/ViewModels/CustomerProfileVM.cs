using Sarafi.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarafi.Models.ViewModels
{
    public class CustomerProfileVM
    {
        public Customer Customer { get; set; }

        public decimal RunningBalance { get; set; }


    }
}
