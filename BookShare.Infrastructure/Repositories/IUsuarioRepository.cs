using BookShare.Domain.Entities;

namespace BookShare.Infrastructure.Repositories
{
    public interface IUsuarioRepository
    {
        public List<Usuario> GetAllUsuarios();
        public Usuario GetUsuario(Guid id);
        public void UpdateUsuario(Usuario usuario);
        public void CreateUsuario(Usuario usuario);
        public void DeleteUsuario(Guid id);
    }
}
