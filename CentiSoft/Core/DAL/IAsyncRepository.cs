using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Core.DAL
{
    public interface IAsyncRepository<T> where T : IIdentifiable
    {
        void SaveAsync(T o);
        Task<T> LoadAsync(int id); //hardcoded identification type!
        Task<List<T>> LoadAllAsync();
        void DeleteAsync(int id); //hardcoded identification type!
        void DeleteAsync(T o);
    }
}
