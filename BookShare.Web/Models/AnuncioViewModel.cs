using static BookShare.Domain.Enums.Enums;

namespace BookShare.Web.Models
{
    public class AnuncioViewModel
    {
        public Guid IdAnuncio { get; set; }
        public Guid IdLivro { get; set; }
        public Guid IdUsuario { get; set; }
        public DateTime DataCriacaoAnuncio { get; set; }
        public StatusAnuncio StatusAnuncio { get; set; }
        public string BairroAnuncio { get; set; } = String.Empty;
        public string CidadeAnuncio { get; set; } = String.Empty;
        public string EstadoAnuncio { get; set; } = String.Empty;
        public DateTime DataCriacao { get; set; }
    }
}
