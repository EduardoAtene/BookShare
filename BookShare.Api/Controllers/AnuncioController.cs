using BookShare.Domain.Dtos;
using BookShare.Domain.Entities;
using BookShare.Services.Service;
using Microsoft.AspNetCore.Mvc;

namespace BookShare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnuncioController : ControllerBase
    {
        private readonly IAnuncioService _anuncioService;
        public AnuncioController(IAnuncioService anuncioService)
        {
            _anuncioService = anuncioService;
        }

        [HttpGet]
        public List<AnuncioDto> Get()
        {
            try
            {
                List<Anuncio> anuncios = _anuncioService.GetAllAnuncios();
                List<AnuncioDto> anunciosDto = anuncios != null ? Anuncio.ConverterParaDto(anuncios) : new List<AnuncioDto>();
                return anunciosDto;
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("{idAnuncio}")]
        public AnuncioDto Get(Guid idAnuncio)
        {
            try
            {
                Anuncio anuncio = _anuncioService.GetAnuncio(idAnuncio);
                AnuncioDto anuncioDto = anuncio != null ? anuncio.ConverterParaDto() : new AnuncioDto();
                return anuncioDto;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public void Post([FromBody] AnuncioDto anuncioDto)
        {
            try
            {
                Anuncio anuncio = anuncioDto != null ? anuncioDto.ConverterParaEntidade() : new Anuncio();
                _anuncioService.CreateAnuncio(anuncio);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut]
        public void Put([FromBody] AnuncioDto anuncioDto)
        {
            try
            {
                Anuncio anuncio = anuncioDto != null ? anuncioDto.ConverterParaEntidade() : new Anuncio();
                _anuncioService.UpdateAnuncio(anuncio);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete]
        [Route("{idAnuncio}")]
        public void Delete(Guid idAnuncio)
        {
            try
            {
                _anuncioService.DeleteAnuncio(idAnuncio);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
