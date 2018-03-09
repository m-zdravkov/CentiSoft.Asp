using Core.DAL.Repositories;
using Core.Models;
using System.Data.Entity;

namespace Core.DAL
{
    /// <summary>
    /// A Customer repository for Entity Framework v.6 persistence
    /// </summary>
    public class ProjectRepositoryEf6 : RepositoryEf6<Project>, IProjectRepository
    {
        public ProjectRepositoryEf6(DbContext context) : base(context)
        {
        }
    }
}
