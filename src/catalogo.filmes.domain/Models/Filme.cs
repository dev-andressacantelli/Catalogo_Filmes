using System;

namespace catalogo.filmes.domain.Models
{
    class Filme
    {
        public string Filme_ID { get; set; }
        public string Titulo { get; set; }
        public string Diretor { get; set; }
        public string Duracao { get; set; }
        public DateTime AnoLancamento { get; set; }
        public string Descricao { get; set; }
        public string Genero { get; set; }
    }
}
