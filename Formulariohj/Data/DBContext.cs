using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Formulariohj.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ConnectionInfo> ConnectionInfos { get; set; }

    }
}
