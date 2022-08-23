using System.Threading.Tasks;

namespace catalogo.filmes.domain.Interfaces
{
    public interface IDispatcherFilme
    {
        Task<object> DespachandoFilmeAsync(string filme);
        Task<object> BuscandotodosFilmesAsync();
        Task<object> BuscandoFilmeEspecificoAsync(string filme_titulo);
    }
}



