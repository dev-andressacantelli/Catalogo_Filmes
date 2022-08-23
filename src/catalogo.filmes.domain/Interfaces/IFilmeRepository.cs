using System.Threading.Tasks;

namespace catalogo.filmes.domain.Interfaces
{
    public interface IFilmeRepository
    {
        Task<object> BuscarTodosFilmesAsync();
        Task<object> BuscandoFilmePorTituloAsync(string titulo_filme);
        Task<object> CadastrandoFilmeAsync(string filme);
    }
}



