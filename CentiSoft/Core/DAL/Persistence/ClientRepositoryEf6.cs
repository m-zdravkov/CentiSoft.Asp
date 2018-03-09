using Core.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace Core.DAL
{
    /// <summary>
    /// A Client repository for Entity Framework v.6 persistence
    /// </summary>
    public class ClientRepositoryEf6 : RepositoryEf6<Client>, IClientRepository
    {
        public ClientRepositoryEf6(DbContext context) : base(context)
        {
        }

        public IEnumerable<Customer> GetClientCustomers(Client client)
        {
            return Load(client).Customers;
        }
    }
}
