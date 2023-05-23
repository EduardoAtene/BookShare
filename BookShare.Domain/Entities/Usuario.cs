using BookShare.Domain.Dtos;
using System.ComponentModel.DataAnnotations;

namespace BookShare.Domain.Entities
{
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; }
        public string NomeUsuario { get; set; } = String.Empty;
        public string EmailUsuario { get; set; } = String.Empty;
        public string SenhaHash { get; set; } = String.Empty;
        public string TelefoneCelular { get; set; } = String.Empty;
        public string Bairro { get; set; } = String.Empty;
        public string Cidade { get; set; } = String.Empty;
        public string Estado { get; set; } = String.Empty;
        public DateTime DataCriacao { get; set; }

        public UsuarioDto ConverterParaDto()
        {
            return new UsuarioDto
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

        public static List<UsuarioDto> ConverterParaDto(List<Usuario> usuarios)
        {
            List<UsuarioDto> usuariosDto = new List<UsuarioDto>();

            foreach (Usuario item in usuarios)
            {
                UsuarioDto dto = item.ConverterParaDto();
                usuariosDto.Add(dto);
            }

            return usuariosDto;
        }
    }
}
