namespace BookShare.Web.Models
{
    public class LivroViewModel
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
    }
}
