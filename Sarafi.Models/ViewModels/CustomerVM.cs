using Sarafi.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Sarafi.Models.ViewModels
{
    public class CustomerVM
    {
        public Customer Customer { get; set; }
        public Transaction Transaction { get; set; }

        public Cashbook Cashbook { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CurrencyList { get; set; }

    }
}
