using catalogo.filmes.domain.Interfaces;
using System.Threading.Tasks;

namespace catalogo.filmes.application
{
    public class DispatcherFilme : IDispatcherFilme
    {      
        private readonly IFilmeRepository _filmeRepository;

        public DispatcherFilme(IFilmeRepository filmeRepository)
        {          
            _filmeRepository = filmeRepository;
        }


        public async Task<object> BuscandoFilmeEspecificoAsync(string titulo_filme) 
        {
            return await _filmeRepository.BuscandoFilmePorTituloAsync(titulo_filme); 
        }

        public async Task<object> BuscandotodosFilmesAsync()
        {
            return await _filmeRepository.BuscarTodosFilmesAsync();   
        }

        public async Task<object> DespachandoFilmeAsync(string filme)
        {
            return await _filmeRepository.CadastrandoFilmeAsync(filme);  
        }
    }
}
