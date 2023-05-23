using BookShare.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookShare.Web.Controllers
{
    public class AnuncioController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string ENDPOINT = "";
        private readonly IConfiguration _configuration;

        public AnuncioController(IConfiguration configuration)
        {
            _httpClient = new HttpClient();
            _configuration = configuration;
            ENDPOINT = _configuration["AppConfig:Endpoints:Url_Api"];
            _httpClient.BaseAddress = new Uri(ENDPOINT + "Anuncio");
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                List<AnuncioViewModel> anuncios = new List<AnuncioViewModel>();
                var response = await _httpClient.GetAsync(ENDPOINT + "Anuncio");

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var retorno = JsonConvert.DeserializeObject<List<AnuncioViewModel>>(content);
                    anuncios = retorno != null ? retorno : new List<AnuncioViewModel>();
                }
                else
                {
                    ModelState.AddModelError(String.Empty, "Erro ao processar a solicitação");
                }
                return View(anuncios);
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw;
            }
        }
    }
}
