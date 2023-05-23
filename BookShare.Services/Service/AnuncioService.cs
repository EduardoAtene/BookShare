using BookShare.Domain.Entities;
using BookShare.Infrastructure.Repositories;

namespace BookShare.Services.Service
{
    public class AnuncioService : IAnuncioService
    {
        private readonly IAnuncioRepository _anuncioRepositoy;
        public AnuncioService(IAnuncioRepository anuncioRepositoy)
        {
            _anuncioRepositoy = anuncioRepositoy;
        }

        public void CreateAnuncio(Anuncio anuncio)
        {
            _anuncioRepositoy.CreateAnuncio(anuncio);
        }

        public void DeleteAnuncio(Guid id)
        {
            _anuncioRepositoy.DeleteAnuncio(id);
        }

        public List<Anuncio> GetAllAnuncios()
        {
            return _anuncioRepositoy.GetAllAnuncios();
        }

        public Anuncio GetAnuncio(Guid id)
        {
            return _anuncioRepositoy.GetAnuncio(id);
        }

        public void UpdateAnuncio(Anuncio anuncio)
        {
            _anuncioRepositoy.UpdateAnuncio(anuncio);
        }
    }
}
