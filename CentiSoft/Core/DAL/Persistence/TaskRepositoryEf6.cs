using Core.DAL.Repositories;
using Core.Models;
using System.Data.Entity;

namespace Core.DAL
{
    /// <summary>
    /// A Customer repository for Entity Framework v.6 persistence
    /// </summary>
    public class TaskRepositoryEf6 : RepositoryEf6<Task>, ITaskRepository
    {
        public TaskRepositoryEf6(DbContext context) : base(context)
        {
        }
    }
}
