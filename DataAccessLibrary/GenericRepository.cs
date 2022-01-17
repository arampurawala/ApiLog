using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccessLibrary
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        internal LogDBEntities Context;
        internal DbSet<TEntity> DbSet;
    
        public GenericRepository(LogDBEntities context)
        {
            this.Context = context;
            this.DbSet = context.Set<TEntity>();
        }
        public virtual void Insert(TEntity entity)
        {
            DbSet.Add(entity);
        }

    }
}
