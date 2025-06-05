using Microsoft.EntityFrameworkCore;
using DotNetEnv;
using Academia2025.Models;

namespace Academia2025.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Membro> Membros { get; set; }
        public DbSet<Treino> Treinos { get; set; }
        public DbSet<Treino> Pagamento { get; set; }
        public DbSet<Treino> Funcionario { get; set; }
        public DbSet<Treino> Historico { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = $"server={Env.GetString("DB_HOST")};" +
                                 $"database={Env.GetString("DB_DATABASE")};" +
                                 $"user={Env.GetString("DB_USER")};" +
                                 $"password={Env.GetString("DB_PASSWORD")}";

            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}