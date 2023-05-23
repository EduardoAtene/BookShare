using BookShare.Domain.Entities;
using BookShare.Infrastructure.Contexts;

namespace BookShare.Infrastructure.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly BookShareDbContext _bookShareDbContext;
        public LivroRepository(BookShareDbContext bookShareDbContext)
        {
            _bookShareDbContext = bookShareDbContext;
        }
        public void CreateLivro(Livro livro)
        {
            _bookShareDbContext.Add(livro);
            _bookShareDbContext.SaveChanges();
        }

        public void DeleteLivro(Guid id)
        {
            var item = _bookShareDbContext.Find<Livro>(id);
            _bookShareDbContext.Remove(item);
            _bookShareDbContext.SaveChanges();
        }

        public List<Livro> GetAllLivros()
        {
            return _bookShareDbContext.Set<Livro>().ToList();
        }

        public Livro GetLivro(Guid id)
        {
            var item = _bookShareDbContext.Find<Livro>(id);
            return item != null ? item : new Livro();
        }

        public void UpdateLivro(Livro livro)
        {
            _bookShareDbContext.Update(livro);
            _bookShareDbContext.SaveChanges();
        }
    }
}
