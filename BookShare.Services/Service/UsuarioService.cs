using BookShare.Domain.Entities;
using BookShare.Infrastructure.Repositories;

namespace BookShare.Services.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepositoy;
        public UsuarioService(IUsuarioRepository usuarioRepositoy)
        {
            _usuarioRepositoy = usuarioRepositoy;
        }

        public void CreateUsuario(Usuario usuario)
        {
            _usuarioRepositoy.CreateUsuario(usuario);
        }

        public void DeleteUsuario(Guid id)
        {
            _usuarioRepositoy.DeleteUsuario(id);
        }

        public List<Usuario> GetAllUsuarios()
        {
            return _usuarioRepositoy.GetAllUsuarios();
        }

        public Usuario GetUsuario(Guid id)
        {
            return _usuarioRepositoy.GetUsuario(id);
        }

        public void UpdateUsuario(Usuario usuario)
        {
            _usuarioRepositoy.UpdateUsuario(usuario);
        }
    }
}
