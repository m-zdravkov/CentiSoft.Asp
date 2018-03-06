using System.Collections.Generic;
using Core.Models;

namespace Core.DAL
{
    public interface IRepository<T> where T : IIdentifiable
    {
        void Save(T o);
        T Load(int id); //hardcoded identification type!
        T Load(T o);
        List<T> LoadAll();
        void Delete(int id); //hardcoded identification type!
        void Delete(T o);
    }
}
