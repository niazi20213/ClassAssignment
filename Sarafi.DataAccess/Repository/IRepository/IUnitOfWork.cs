using Sarafi.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarafi.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        public IHawalaRepository Hawala { get; }
        public ICustomerRepository Customer { get; }
        public IZCurrencyRepository ZCurrency { get; }
        public void Save();
    }
}
