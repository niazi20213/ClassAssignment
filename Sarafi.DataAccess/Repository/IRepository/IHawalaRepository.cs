using Sarafi.Models;
using Sarafi.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarafi.DataAccess.Repository.IRepository
{
    public interface IHawalaRepository:IRepository<Hawala>
    {
        void Update(Hawala obj);
    }
}
