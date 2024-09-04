

using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using minimal_api.Domain.Entities;
using minimal_api.Domain.Services;
using MinimalApi.Infra.Db;

namespace Test.Domain.Entities;

[TestClass]
public class AdministradorServicoTest
{
  private DbContexto CriarContextoDeTeste()
  {
    //Configurar o Configuration Builder
    var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    var path = Path.GetFullPath(Path.Combine(assemblyPath ?? "", "..", "..", ".."));

    var builder = new ConfigurationBuilder()
    .SetBasePath(path ?? Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables();
    var configuration = builder.Build();

    //Obter a String de Conexão
    var connectionString = configuration.GetConnectionString("Postgres");

    //Configurar o DbContextOptionsBuilder
    var options = new DbContextOptionsBuilder<DbContexto>()
    .UseNpgsql(connectionString)
    .Options;
    
    return new DbContexto(options);
  }

  [TestMethod]
  public void TestandoSalvarAdm()
  {
    //Arrange
    var context = CriarContextoDeTeste();
    context.Database.ExecuteSqlRaw("TRUNCATE TABLE Administradores");

    var adm = new Administrador();
    adm.Id = 1;
    adm.Email = "teste@teste.com";
    adm.Senha = "teste@teste.com";
    adm.Perfil = "Administrador";

    var administradorServico = new AdministradorServico(context);

    //Act

    administradorServico.Incluir(adm);
    var admDoBanco = administradorServico.BuscarPorId(adm.Id);

    //Assert

    Assert.AreEqual(1, admDoBanco?.Id);
    
  }
}