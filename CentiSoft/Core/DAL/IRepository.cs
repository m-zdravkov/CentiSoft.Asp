using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public interface IRepository<T>
    {
        void Save(T o);
        T Load(T o);
        List<T> LoadAll();
        void Delete(T o);
    }
}
