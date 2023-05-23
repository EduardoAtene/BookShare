using BookShare.Domain.Entities;
using BookShare.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookShare.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string ENDPOINT = "";
        private readonly IConfiguration _configuration;

        public UsuarioController(IConfiguration configuration)
        {
            _httpClient = new HttpClient();
            _configuration = configuration;
            ENDPOINT = _configuration["AppConfig:Endpoints:Url_Api"];
            _httpClient.BaseAddress = new Uri(ENDPOINT + "Usuario");
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                List<UsuarioViewModel> usuarios = new List<UsuarioViewModel>();
                var response = await _httpClient.GetAsync(ENDPOINT + "Usuario");

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var retorno = JsonConvert.DeserializeObject<List<UsuarioViewModel>>(content);
                    usuarios = retorno != null ? retorno : new List<UsuarioViewModel>();
                }
                else
                {
                    ModelState.AddModelError(String.Empty, "Erro ao processar a solicitação");
                }
                return View(usuarios);
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw;
            }
        }
    }
}
