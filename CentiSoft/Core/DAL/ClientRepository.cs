using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class ClientRepository : IRepository<Client>
    {
        public void Delete(Client o)
        {
            throw new NotImplementedException();
        }

        public Client Load(Client o)
        {
            using (var context = new CentiSoftContext())
            {
                return context.Clients.FirstOrDefault(record => record.Id == o.Id);
            }
        }

        public List<Client> LoadAll()
        {
            using (var context = new CentiSoftContext())
            {
                return context.Clients.ToList();
            }
        }

        public void Save(Client o)
        {
            using (var context = new CentiSoftContext())
            {
                context.Clients.Add(o);
                context.SaveChanges();
            }
        }
    }
}
