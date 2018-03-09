using Core.DAL.Repositories;
using System.Data.Entity;

namespace Core.DAL
{
    public class UnitOfWorkEf6 : IUnitOfWork
    {
        private readonly CentiSoftContext _ctx;

        public IClientRepository Clients { get; set; }
        public ICustomerRepository Customers { get; set; }
        public IProjectRepository Projects { get; set; }
        public IDeveloperRepository Developers { get; set; }
        public ITaskRepository Tasks { get; set; }

        public UnitOfWorkEf6(CentiSoftContext context)
        {
            _ctx = context;
            Clients = new ClientRepositoryEf6(_ctx);
            Customers = new CustomerRepositoryEf6(_ctx);
            Projects = new ProjectRepositoryEf6(_ctx);
            Developers = new DeveloperRepositoryEf6(_ctx);
            Tasks = new TaskRepositoryEf6(_ctx);
        }

        public void Complete()
        {
            _ctx.SaveChanges();
        }
    }
}
