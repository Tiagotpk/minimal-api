

using minimal_api.Domain.Entities;

namespace Test.Domain.Entities;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestGetSetProperties()
    {
      //Arrange
      var adm = new Administrador();

      //Act
      adm.Id = 1;
      adm.Email = "teste@teste.com";
      adm.Senha = "teste@teste.com";
      adm.Perfil = "Administrador";


      //Assert

      Assert.AreEqual(1, adm.Id);
      Assert.AreEqual("teste@teste.com", adm.Email);
      Assert.AreEqual("teste@teste.com", adm.Senha);
      Assert.AreEqual("Administrador", adm.Perfil);
    }
}