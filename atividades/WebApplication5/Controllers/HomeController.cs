using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult PrintNaturalNumbers(int count = 10)
        {
            string result = NaturalNumberRecursion(1, count);
            return Content(result); // Retorna o resultado como conteúdo
        }

        private string NaturalNumberRecursion(int n, int count)
        {
            // Caso base: se o contador for menor que 1, retorna uma string vazia
            if (count < 1)
                return string.Empty;

            // Adiciona o número atual à string de retorno
            string ret = $"{n} ";

            // Chamada recursiva: incrementa n e decrementa count
            ret += NaturalNumberRecursion(n + 1, count - 1);

            return ret;
        }
    }
}