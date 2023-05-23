using BookShare.Domain.Entities;
using BookShare.Infrastructure.Contexts;

namespace BookShare.Infrastructure.Repositories
{
    public class AnuncioRepository : IAnuncioRepository
    {
        private readonly BookShareDbContext _bookShareDbContext;
        public AnuncioRepository(BookShareDbContext bookShareDbContext)
        {
            _bookShareDbContext = bookShareDbContext;
        }
        public void CreateAnuncio(Anuncio anuncio)
        {
            _bookShareDbContext.Add(anuncio);
            _bookShareDbContext.SaveChanges();
        }

        public void DeleteAnuncio(Guid id)
        {
            var item = _bookShareDbContext.Find<Anuncio>(id);
            _bookShareDbContext.Remove(item);
            _bookShareDbContext.SaveChanges();
        }

        public List<Anuncio> GetAllAnuncios()
        {
            return _bookShareDbContext.Set<Anuncio>().ToList();
        }

        public Anuncio GetAnuncio(Guid id)
        {
            var item = _bookShareDbContext.Find<Anuncio>(id);
            return item != null ? item : new Anuncio();
        }

        public void UpdateAnuncio(Anuncio anuncio)
        {
            _bookShareDbContext.Update(anuncio);
            _bookShareDbContext.SaveChanges();
        }
    }
}
