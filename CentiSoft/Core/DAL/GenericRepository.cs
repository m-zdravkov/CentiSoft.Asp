using Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Core.DAL
{
    /// <summary>
    /// Executes generic code, takes in DB set. Coupled with CentiSoftContext
    /// </summary>
    class GenericAsyncRepository<T> : IAsyncRepository<T> where T : class, IIdentifiable
    {
        private DbContext CreateContext()
        {
            return new CentiSoftContext();
        }

        public async void DeleteAsync(int id)
        {
            using (var context = CreateContext())
            {
                T o = await LoadContextualAsync(context, id);

                context.Set<T>().Attach(o);
                context.Set<T>().Remove(o);

                context.SaveChanges();
            }
        }

        public void DeleteAsync(T o)
        {
            DeleteAsync(o.Id);
        }

        public async Task<T> LoadAsync(int id)
        {
            using (var context = CreateContext())
            {
                return await LoadContextualAsync(context, id);
            }
        }

        public async Task<List<T>> LoadAllAsync()
        {
            using (var context = CreateContext())
            {
                return await context.Set<T>().ToListAsync();
            }
        }

        public async void SaveAsync(T o)
        {
            using (var context = CreateContext())
            {
                T existing = await LoadContextualAsync(context, o.Id);

                if (existing == null)
                {
                    Create(o);
                }
                else
                {
                    Update(o);
                }

                await context.SaveChangesAsync();
            }
        }

        private void Create(T o)
        {
            using (var context = CreateContext())
            {
                context.Set<T>().Add(o);
                context.SaveChanges();
            }
        }

        private void Update(T o)
        {
            using (var context = CreateContext())
            {
                context.Set<T>().Attach(o);
                context.Entry<T>(o).State = EntityState.Modified;
            }
        }

        private async Task<T> LoadContextualAsync(DbContext context, int id)
        {
            return await context.Set<T>().SingleOrDefaultAsync(r => r.Id == id);
        }
    }
}
