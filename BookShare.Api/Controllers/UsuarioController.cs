using BookShare.Domain.Dtos;
using BookShare.Domain.Entities;
using BookShare.Services.Service;
using Microsoft.AspNetCore.Mvc;

namespace BookShare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public List<UsuarioDto> Get()
        {
            try
            {
                List<Usuario> usuarios = _usuarioService.GetAllUsuarios();
                List<UsuarioDto> usuariosDto = usuarios != null ? Usuario.ConverterParaDto(usuarios) : new List<UsuarioDto>();
                return usuariosDto;
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("{idUsuario}")]
        public UsuarioDto Get(Guid idUsuario)
        {
            try
            {
                Usuario usuario = _usuarioService.GetUsuario(idUsuario);
                UsuarioDto usuarioDto = usuario != null ? usuario.ConverterParaDto() : new UsuarioDto();
                return usuarioDto;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public void Post([FromBody] UsuarioDto usuarioDto)
        {
            try
            {
                Usuario usuario = usuarioDto != null ? usuarioDto.ConverterParaEntidade() : new Usuario();
                _usuarioService.CreateUsuario(usuario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut]
        public void Put([FromBody] UsuarioDto usuarioDto)
        {
            try
            {
                Usuario usuario = usuarioDto != null ? usuarioDto.ConverterParaEntidade() : new Usuario();
                _usuarioService.UpdateUsuario(usuario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete]
        [Route("{idUsuario}")]
        public void Delete(Guid idUsuario)
        {
            try
            {
                _usuarioService.DeleteUsuario(idUsuario);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
