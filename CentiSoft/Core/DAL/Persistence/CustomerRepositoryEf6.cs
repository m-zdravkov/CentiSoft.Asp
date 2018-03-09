using Core.DAL.Repositories;
using Core.Models;
using System.Data.Entity;

namespace Core.DAL
{
    /// <summary>
    /// A Customer repository for Entity Framework v.6 persistence
    /// </summary>
    public class CustomerRepositoryEf6 : RepositoryEf6<Customer>, ICustomerRepository
    {
        public CustomerRepositoryEf6(DbContext context) : base(context)
        {
        }
    }
}
