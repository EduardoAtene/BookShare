using BookShare.Domain.Entities;

namespace BookShare.Domain.Dtos
{
    public class LivroDto
    {
        public Guid IdLivro { get; set; }
        public string Isbn { get; set; } = String.Empty;
        public string Titulo { get; set; } = String.Empty;
        public string Subtitulo { get; set; } = String.Empty;
        public DateTime DataPublicacao { get; set; }
        public string Editora { get; set; } = String.Empty;
        public string Genero { get; set; } = String.Empty;
        public string Autor { get; set; } = String.Empty;
        public DateTime DataCriacao { get; set; }

        public Livro ConverterParaEntidade()
        {
            return new Livro
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

        public List<Livro> ConverterParaEntidade(List<LivroDto> livrosDtos)
        {
            List<Livro> livros = new List<Livro>();

            foreach (LivroDto item in livrosDtos)
            {
                Livro entidade = item.ConverterParaEntidade();
                livros.Add(entidade);
            }

            return livros;
        }
    }
}
