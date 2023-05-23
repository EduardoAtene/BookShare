using BookShare.Domain.Entities;
using BookShare.Infrastructure.Contexts;

namespace BookShare.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly BookShareDbContext _bookShareDbContext;
        public UsuarioRepository(BookShareDbContext bookShareDbContext)
        {
            _bookShareDbContext = bookShareDbContext;
        }
        public void CreateUsuario(Usuario usuario)
        {
            _bookShareDbContext.Add(usuario);
            _bookShareDbContext.SaveChanges();
        }

        public void DeleteUsuario(Guid id)
        {
            var item = _bookShareDbContext.Find<Usuario>(id);
            _bookShareDbContext.Remove(item);
            _bookShareDbContext.SaveChanges();
        }

        public List<Usuario> GetAllUsuarios()
        {
            return _bookShareDbContext.Set<Usuario>().ToList();
        }

        public Usuario GetUsuario(Guid id)
        {
            var item = _bookShareDbContext.Find<Usuario>(id);
            return item != null ? item : new Usuario();
        }

        public void UpdateUsuario(Usuario usuario)
        {
            _bookShareDbContext.Update(usuario);
            _bookShareDbContext.SaveChanges();
        }
    }
}
