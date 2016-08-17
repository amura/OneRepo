using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace OneRepo.Controllers
{
    public class RepoItemContext : DbContext
    {
        public RepoItemContext() : base("DefaultConnection")
        {

        }

        public DbSet<RepoItem> RepoItems { get; set; }
    }
}
