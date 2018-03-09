using System.Collections.Generic;
using Core.Models;

namespace Core.DAL
{
    public interface IRepository<TEntity> where TEntity : IIdentifiable
    {
        void Add(TEntity record);
        void AddRange(IEnumerable<TEntity> records);

        TEntity Load(int id); //hardcoded identification type!
        TEntity Load(TEntity record);
        IEnumerable<TEntity> LoadAll();
        IEnumerable<TEntity> LoadPage(int pageIndex, int pageSize);

        void Delete(int id); //hardcoded identification type!
        void Delete(TEntity record);
        void DeleteRange(IEnumerable<TEntity> records);
    }
}
