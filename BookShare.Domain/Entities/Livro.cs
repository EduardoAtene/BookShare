using BookShare.Domain.Dtos;
using System.ComponentModel.DataAnnotations;

namespace BookShare.Domain.Entities
{
    public class Livro
    {
        [Key]
        public Guid IdLivro { get; set; }
        public string Isbn { get; set; } = String.Empty;
        public string Titulo { get; set; } = String.Empty;
        public string Subtitulo { get; set; } = String.Empty;
        public DateTime DataPublicacao { get; set; }
        public string Editora { get; set; } = String.Empty;
        public string Genero { get; set; } = String.Empty;
        public string Autor { get; set; } = String.Empty;
        public DateTime DataCriacao { get; set; }

        public LivroDto ConverterParaDto()
        {
            return new LivroDto
            {
                IdLivro = this.IdLivro,
                Isbn = this.Isbn,
                Titulo = this.Titulo,
                Subtitulo = this.Subtitulo,
                DataPublicacao = this.DataPublicacao,
                Editora = this.Editora,
                Genero = this.Genero,
                Autor = this.Autor,
                DataCriacao = this.DataCriacao
            };
        }

        public static List<LivroDto> ConverterParaDto(List<Livro> livros)
        {
            List<LivroDto> livrosDto = new List<LivroDto>();

            foreach (Livro item in livros)
            {
                LivroDto dto = item.ConverterParaDto();
                livrosDto.Add(dto);
            }

            return livrosDto;
        }
    }
}
