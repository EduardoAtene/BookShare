using BookShare.Domain.Entities;
using static BookShare.Domain.Enums.Enums;

namespace BookShare.Domain.Dtos
{
    public class AnuncioDto
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

        public Anuncio ConverterParaEntidade()
        {
            return new Anuncio
            {
                IdAnuncio = this.IdAnuncio,
                IdLivro = this.IdLivro,
                IdUsuario = this.IdUsuario,
                DataCriacaoAnuncio = this.DataCriacaoAnuncio,
                StatusAnuncio = this.StatusAnuncio,
                BairroAnuncio = this.BairroAnuncio,
                CidadeAnuncio = this.CidadeAnuncio,
                EstadoAnuncio = this.EstadoAnuncio,
                DataCriacao = this.DataCriacao
            };
        }

        public List<Anuncio> ConverterParaEntidade(List<AnuncioDto> anunciosDtos)
        {
            List<Anuncio> anuncios = new List<Anuncio>();

            foreach (AnuncioDto item in anunciosDtos)
            {
                Anuncio entidade = item.ConverterParaEntidade();
                anuncios.Add(entidade);
            }

            return anuncios;
        }
    }
}
