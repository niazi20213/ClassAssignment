using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Sarafi.DataAccess.Data;
using Sarafi.DataAccess.Repository;
using Sarafi.DataAccess.Repository.IRepository;
using Sarafi.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sarafi.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        internal DbSet<T> dbset;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            dbset = _context.Set<T>();
        }
        public void Add(T entity)
        {
           dbset.Add(entity);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperies = null)
        {
            IQueryable<T> query = dbset;
            if (filter != null)
                query = query.Where(filter);
            if (includeProperies != null)
            {
                foreach (var includeProperty in includeProperies.Split(new char[] { ',' }))
                {
                    query = query.Include(includeProperty);
                }
            }

            return query.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperies = null, bool tracked = true)
        {
            IQueryable<T> query=dbset;
            if(filter != null)
                query=query.Where(filter);
            if(includeProperies != null)
            {
                foreach(var includeProperty in includeProperies.Split(new char[] { ','}))
                {
                    query=query.Include(includeProperty);
                }
            }
            return query.FirstOrDefault();
        }

  

        public void Remove(T entity)
        {
            dbset.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            dbset.RemoveRange(entities);
        }
    }
}
