using Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    /// <summary>
    /// Generic repository for Entity Framework v.6 persistence
    /// </summary>
    /// <typeparam name="TEntity">Type of persisted entity</typeparam>
    public class RepositoryEf6<TEntity> : IRepository<TEntity>
        where TEntity : class, IIdentifiable
    {
        protected readonly DbContext Context;

        public RepositoryEf6(DbContext context)
        {
            Context = context;
        }

        protected CentiSoftContext CentiSoftContext
        {
            get
            {
                return Context as CentiSoftContext;
            }
        }

        public void Add(TEntity record)
        {
            Context.Set<TEntity>().Add(record);
        }

        public void AddRange(IEnumerable<TEntity> records)
        {
            Context.Set<TEntity>().AddRange(records);
        }

        public void Delete(int id)
        {
            Context.Set<TEntity>().Remove(Load(id));
        }

        public void Delete(TEntity record)
        {
            var entity = Context.Entry(record);
            entity.State = EntityState.Deleted;
        }

        public void DeleteRange(IEnumerable<TEntity> records)
        {
            Context.Set<TEntity>().RemoveRange(records);
        }

        public TEntity Load(int id)
        {
            return Context.Set<TEntity>().SingleOrDefault(record => record.Id == id);
        }

        public TEntity Load(TEntity record)
        {
            return Load(record.Id);
        }

        public IEnumerable<TEntity> LoadAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> LoadPage(int pageIndex = 0, int pageSize = 10)
        {
            return Context.Set<TEntity>().Skip(pageIndex * pageSize).Take(pageSize).ToList();
        }
    }
}
