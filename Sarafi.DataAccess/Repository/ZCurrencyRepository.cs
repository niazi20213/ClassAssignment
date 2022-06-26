using Sarafi.DataAccess.Data;
using Sarafi.DataAccess.Repository.IRepository;
using Sarafi.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarafi.DataAccess.Repository
{
    public class ZCurrencyRepository:Repository<ZCurrency>,IZCurrencyRepository
    {
        private readonly ApplicationDbContext _context;
        public ZCurrencyRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }
    }
}
