using Academia2025.Models;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;

namespace Academia2025.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Membro> Membros { get; set; }
        public DbSet<Treino> Treinos { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Historico> Historicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DotNetEnv.Env.Load();

            var host = Env.GetString("DB_HOST");
            var db = Env.GetString("DB_DATABASE");
            var user = Env.GetString("DB_USER");
            var pass = Env.GetString("DB_PASSWORD");

            var connectionString = $"server={host};database={db};user={user};password={pass}";

            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}