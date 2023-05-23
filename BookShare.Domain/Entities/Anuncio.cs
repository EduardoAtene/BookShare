using BookShare.Domain.Dtos;
using System.ComponentModel.DataAnnotations;
using static BookShare.Domain.Enums.Enums;

namespace BookShare.Domain.Entities
{
    public class Anuncio
    {
        [Key]
        public Guid IdAnuncio { get; set; }
        public Guid IdLivro { get; set; }
        public Guid IdUsuario { get; set; }
        public DateTime DataCriacaoAnuncio { get; set; }
        public StatusAnuncio StatusAnuncio { get; set; }
        public string BairroAnuncio { get; set; } = String.Empty;
        public string CidadeAnuncio { get; set; } = String.Empty;
        public string EstadoAnuncio { get; set; } = String.Empty;
        public DateTime DataCriacao { get; set; }

        public AnuncioDto ConverterParaDto()
        {
            return new AnuncioDto
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

        public static List<AnuncioDto> ConverterParaDto(List<Anuncio> anuncios)
        {
            List<AnuncioDto> anunciosDto = new List<AnuncioDto>();

            foreach (Anuncio item in anuncios)
            {
                AnuncioDto dto = item.ConverterParaDto();
                anunciosDto.Add(dto);
            }

            return anunciosDto;
        }
    }
}
