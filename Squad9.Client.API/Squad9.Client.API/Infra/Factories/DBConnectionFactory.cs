using Microsoft.EntityFrameworkCore;
using Squad9.Client.API.Entities;

namespace Squad9.Client.API.Infra.Factories
{
    public class DBConnectionFactory : DbContext
    {
        public DBConnectionFactory(DbContextOptions<DBConnectionFactory> options)
            : base(options)
        { }

        public DbSet<ClientEntities> Client { get; set; }
        public DbSet<AcordoFinanceiraEntities> Acordos { get; set; }        
        public DbSet<DadosDividasEntities> Dividas { get; set; }

    }

}
