using BookShare.Domain.Entities;
using BookShare.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookShare.Web.Controllers
{
    public class LivroController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string ENDPOINT = "";
        private readonly IConfiguration _configuration;

        public LivroController(IConfiguration configuration)
        {
            _httpClient = new HttpClient();
            _configuration = configuration;
            ENDPOINT = _configuration["AppConfig:Endpoints:Url_Api"];
            _httpClient.BaseAddress = new Uri(ENDPOINT + "Livro");
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                List<LivroViewModel> livros = new List<LivroViewModel>();
                var response = await _httpClient.GetAsync(ENDPOINT + "Livro");

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    var retorno = JsonConvert.DeserializeObject<List<LivroViewModel>>(content);
                    livros = retorno != null ? retorno : new List<LivroViewModel>();
                }
                else
                {
                    ModelState.AddModelError(String.Empty, "Erro ao processar a solicitação");
                }
                return View(livros);
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw;
            }
        }
    }
}
