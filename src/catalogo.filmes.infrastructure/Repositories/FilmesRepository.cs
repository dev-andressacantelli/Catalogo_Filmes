using catalogo.filmes.domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace catalogo.filmes.infrastructure.Repositories
{
    public class FilmesRepository : IFilmeRepository
    {
        public Task<object> BuscandoFilmePorTituloAsync(string titulo_filme)
        {
            throw new NotImplementedException();
        }

        public Task<object> BuscarTodosFilmesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<object> CadastrandoFilmeAsync(string filme)
        {
            throw new NotImplementedException();
        }
    }
}
