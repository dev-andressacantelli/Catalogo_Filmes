using catalogo.filmes.domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace catalogo.filmes.api.Controllers
{
    public class FilmeController : ControllerBase
    {
        private readonly IDispatcherFilme _dispatcher;
        public FilmeController(IDispatcherFilme dispatcher)
        {
            _dispatcher = dispatcher;
        }

        /*
        [HttpPost]
        [Route("filmes")]
        public async Task<IActionResult> PostFilme(string filme)
        {
            var retorno = await _dispatcher.DespachandoFilmeAsync(filme);
            if (retorno != false)
            {
                return Ok(retorno);
            }

            return BadRequest(new { erro = "Erro ao tentar registrar filme" });
        } */

        [HttpGet]
        [Route("filmeID")]
        public async Task<IActionResult> GetFilmeEspecifico(string filme_ID)
        {
            var retorno = await _dispatcher.BuscandoFilmeEspecificoAsync(filme_ID);  //BuscandoClienteEspecificoAsync(cliente_ID);
            if (retorno != null)
            {
                return Ok(retorno);
            }

            return BadRequest(new { erro = "Erro ao tentar buscar filme específico!" });
        }

        [HttpGet]
        [Route("filmes")]
        public async Task<IActionResult> GetAllFilmes()
        {
            var retorno = await _dispatcher.BuscandotodosFilmesAsync();  
            if (retorno != null)
            {
                return Ok(retorno);
            }

            return BadRequest(new { erro = "Erro ao tentar buscar filmes!" });
        }

    }
}
