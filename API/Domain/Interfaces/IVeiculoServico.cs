using minimal_api.Domain.Entities;

public interface IVeiculoServico
{
    void Apagar(Veiculo veiculo);
    void Atualizar(Veiculo veiculo);
    Veiculo? BuscaPorId(int id);
    void Incluir(Veiculo veiculo);
    List<Veiculo> Todos(int? pagina = 1, string? nome = null, string? marca = null);
}
