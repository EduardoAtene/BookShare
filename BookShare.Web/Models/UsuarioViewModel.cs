namespace BookShare.Web.Models
{
    public class UsuarioViewModel
    {
        public Guid IdUsuario { get; set; }
        public string NomeUsuario { get; set; } = String.Empty;
        public string EmailUsuario { get; set; } = String.Empty;
        public string SenhaHash { get; set; } = String.Empty;
        public string TelefoneCelular { get; set; } = String.Empty;
        public string Bairro { get; set; } = String.Empty;
        public string Cidade { get; set; } = String.Empty;
        public string Estado { get; set; } = String.Empty;
        public DateTime DataCriacao { get; set; }
    }
}
