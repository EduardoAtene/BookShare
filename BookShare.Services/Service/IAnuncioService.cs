using BookShare.Domain.Entities;

namespace BookShare.Services.Service
{
    public interface IAnuncioService
    {
        public List<Anuncio> GetAllAnuncios();
        public Anuncio GetAnuncio(Guid id);
        public void UpdateAnuncio(Anuncio anuncio);
        public void CreateAnuncio(Anuncio anuncio);
        public void DeleteAnuncio(Guid id);
    }
}
