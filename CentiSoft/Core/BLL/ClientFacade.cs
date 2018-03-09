using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Core.DAL;

namespace Core.BLL
{
    public class ClientFacade
    {
        public IUnitOfWork UnitOfWork { get; }

        public ClientFacade(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
        
        public void CreateClient(string name)
        {
            UnitOfWork.Clients.Add(new Client { Name = name });
            UnitOfWork.Complete();
        }
    }
}
