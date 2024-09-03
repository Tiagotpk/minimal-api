using Microsoft.EntityFrameworkCore;
using minimal_api.Domain.Entities;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace MinimalApi.Infra.Db
{
    public class DbContexto : DbContext
    {
        public DbSet<Administrador> Administradores { get; set; } = default!;
        public DbSet<Veiculo> Veiculos { get; set; } = default!;

        public DbContexto(DbContextOptions<DbContexto> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrador>().HasData(
                new Administrador
                {
                    Id = 1,
                    Email = "adm@teste.com",
                    Senha = "123456",
                    Perfil = "Administrador"
                }
            );
        }
    }
}
