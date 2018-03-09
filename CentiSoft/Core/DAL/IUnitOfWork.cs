using Core.Models;
using Core.DAL.Repositories;
using System;

namespace Core.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IClientRepository Clients { get; }
        ICustomerRepository Customers { get; }
        IDeveloperRepository Developers { get; }
        IProjectRepository Projects { get; }
        ITaskRepository Tasks { get; }
        void Complete();
    }
}
