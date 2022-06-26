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
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly ApplicationDbContext _context;
        public CustomerRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }
        public void Update(Customer obj)
        {
            _context.Update(obj);
        }
    }
}
