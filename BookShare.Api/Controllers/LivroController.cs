using BookShare.Domain.Dtos;
using BookShare.Domain.Entities;
using BookShare.Services.Service;
using Microsoft.AspNetCore.Mvc;

namespace BookShare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroService _livroService;
        public LivroController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        [HttpGet]
        public List<LivroDto> Get()
        {
            try
            {
                List<Livro> livros = _livroService.GetAllLivros();
                List<LivroDto> livrosDto = livros != null ? Livro.ConverterParaDto(livros) : new List<LivroDto>();
                return livrosDto;
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("{idLivro}")]
        public LivroDto Get(Guid idLivro)
        {
            try
            {
                Livro livro = _livroService.GetLivro(idLivro);
                LivroDto livroDto = livro != null ? livro.ConverterParaDto() : new LivroDto();
                return livroDto;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public void Post([FromBody] LivroDto livroDto)
        {
            try
            {
                Livro livro = livroDto != null ? livroDto.ConverterParaEntidade() : new Livro();
                _livroService.CreateLivro(livro);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut]
        public void Put([FromBody] LivroDto livroDto)
        {
            try
            {
                Livro livro = livroDto != null ? livroDto.ConverterParaEntidade() : new Livro();
                _livroService.UpdateLivro(livro);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete]
        [Route("{idLivro}")]
        public void Delete(Guid idLivro)
        {
            try
            {
                _livroService.DeleteLivro(idLivro);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
