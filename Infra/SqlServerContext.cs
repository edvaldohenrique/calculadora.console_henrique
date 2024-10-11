using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class SqlServerContext : DbContext
    {
        public DbSet<Operacao> Operacoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlServer("Server=AsusVivoBook; Database=calculadora_frwk; Integrated Security=true; TrustServerCertificate=true;");
    }
}
