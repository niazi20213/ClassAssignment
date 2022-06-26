using Sarafi.DataAccess.Data;
using Sarafi.DataAccess.Repository;
using Sarafi.DataAccess.Repository.IRepository;
using Sarafi.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarafi.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Hawala = new HawalaRepository(_context);
            Customer = new CustomerRepository(_context);
            ZCurrency = new ZCurrencyRepository(_context);
        }


        public IHawalaRepository Hawala { get; private set; }

        public ICustomerRepository Customer { get; private set; }

        public IZCurrencyRepository ZCurrency { get; private set; }

        public void Save()
        {
           _context.SaveChanges();
        }
    }
}
