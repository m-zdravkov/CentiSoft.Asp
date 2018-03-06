using Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Core.DAL
{
    /// <summary>
    /// Executes generic code, takes in DB set. Coupled with CentiSoftContext
    /// </summary>
    class GenericRepository<T> : IRepository<T> where T : class, IIdentifiable
    {
        public void Delete(int id)
        {
            using (var context = new CentiSoftContext())
            {
                ///TODO: FINISH
                /*var schema = context.Set<T>();
                schema.Attach(o);
                schema.Remove(o);

                context.SaveChanges();*/
            }
        }

        public void Delete(T o)
        {
            using(var context = new CentiSoftContext())
            {
                var schema = context.Set<T>();
                schema.Attach(o);
                schema.Remove(o);

                context.SaveChanges();
            }
        }

        public T Load(int id)
        {
            throw new NotImplementedException();
        }

        public T Load(T o)
        {
            throw new NotImplementedException();
        }

        public List<T> LoadAll()
        {
            throw new NotImplementedException();
        }

        public void Save(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(T o)
        {
            throw new NotImplementedException();
        }
    }
}
