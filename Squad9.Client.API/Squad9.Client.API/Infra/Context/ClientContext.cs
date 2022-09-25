using Microsoft.EntityFrameworkCore;
using Squad9.Client.API.Entities;

namespace Squad9.Client.API.Infra.Context
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options) 
            : base(options) => Database.EnsureCreated();

        public DbSet<ClientEntities> Cliente { get; set; }
    }
}
