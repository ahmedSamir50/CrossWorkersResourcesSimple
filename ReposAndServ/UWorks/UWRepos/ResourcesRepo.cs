using DataAccess.Entities;
using DataAccess.WorkersDbContext;
using Microsoft.EntityFrameworkCore;
using ReposAndServ.Interfaces;
using ReposAndServ.Repository;

namespace ReposAndServ.UWorks.UWRepos
{
    public class ResourcesRepo : CrossWorkesRepo<Resource>, IResourceRepo
    {
        public ResourcesRepo(DbContextOptions opt, ResourcesDbContext context = null) : base(opt, context) { }
    }
}
