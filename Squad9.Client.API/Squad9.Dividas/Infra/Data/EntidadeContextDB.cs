using Microsoft.EntityFrameworkCore;
using Squad9.Dividas;
using Squad9.Entidade.API.Entitie;

namespace Squad9.Entidade.API.Infra.Data
{
    public class EntidadeContextDB : DbContext
    {   
        public EntidadeContextDB(DbContextOptions<EntidadeContextDB> options)
           : base(options)
        { }

        public DbSet<EntidadeEntitie> Client { get; set; }
        public DbSet<PropostasEntitie> Acordos { get; set; }

    }
}
