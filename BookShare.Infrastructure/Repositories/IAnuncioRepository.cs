using BookShare.Domain.Entities;

namespace BookShare.Infrastructure.Repositories
{
    public interface IAnuncioRepository
    {
        public List<Anuncio> GetAllAnuncios();
        public Anuncio GetAnuncio(Guid id);
        public void UpdateAnuncio(Anuncio anuncio);
        public void CreateAnuncio(Anuncio anuncio);
        public void DeleteAnuncio(Guid id);
    }
}
