namespace MinimalApi.Infra.Db;

public class DbContext : DbContext
    {
        public DbSet<Estudante>Estudantes{get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=Estudantes;User Id=postgres;Password=SUASENHA");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }
    }