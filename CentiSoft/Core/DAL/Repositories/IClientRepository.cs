using Core.Models;
using System.Collections.Generic;

namespace Core.DAL
{
    public interface IClientRepository : IRepository<Client>
    {
        IEnumerable<Customer> GetClientCustomers(Client client);
    }
}
