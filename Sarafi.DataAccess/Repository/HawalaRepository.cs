using Sarafi.DataAccess.Data;
using Sarafi.DataAccess.Repository;
using Sarafi.DataAccess.Repository.IRepository;
using Sarafi.Models;
using Sarafi.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarafi.DataAccess.Repository
{
    public class HawalaRepository : Repository<Hawala>, IHawalaRepository
    {
        private readonly ApplicationDbContext _context;
        public HawalaRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }
        public void Update(Hawala obj)
        {
            _context.Update(obj);
        }
    }
}
