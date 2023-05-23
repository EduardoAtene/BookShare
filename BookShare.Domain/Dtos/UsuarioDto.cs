using BookShare.Domain.Entities;

namespace BookShare.Domain.Dtos
{
    public class UsuarioDto
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

        public Usuario ConverterParaEntidade()
        {
            return new Usuario
            {
                IdUsuario = this.IdUsuario,
                NomeUsuario = this.NomeUsuario,
                EmailUsuario = this.EmailUsuario,
                SenhaHash = this.SenhaHash,
                TelefoneCelular = this.TelefoneCelular,
                Bairro = this.Bairro,
                Cidade = this.Cidade,
                Estado = this.Estado,
                DataCriacao = this.DataCriacao
            };
        }

        public List<Usuario> ConverterParaEntidade(List<UsuarioDto> usuariosDtos)
        {
            List<Usuario> usuarios = new List<Usuario>();

            foreach (UsuarioDto item in usuariosDtos)
            {
                Usuario entidade = item.ConverterParaEntidade();
                usuarios.Add(entidade);
            }

            return usuarios;
        }
    }
}
