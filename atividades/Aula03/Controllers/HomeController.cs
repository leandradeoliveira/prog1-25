using System.Diagnostics;
using Aula03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string GetIf(int x)
        {
            string retorno = string.Empty;

            if (x < 9)
                return "x é menor que nove";

            if (x > 9)
                retorno = "x é maior que nove";
            else
                retorno = "x é igual a nove";

            if (x > 10)
            {
                retorno = "ora ora";
                retorno += " x é maior que 10";
            }
            else if (x == 9)
            {
                retorno = "hmm";
                retorno += " x é igual a 9";
            }
            else if (x == 8)
            {
                retorno = "bahh";
                retorno += " x é igual a 8";
            }
            else
            {
                retorno = "que bosta é essa!";
            }

            return retorno;
        }

        [HttpGet]
        public string GetSwitch(int x)
        {
            string retorno = string.Empty;
            switch (x)
            {
                case 0:
                    retorno = "x é zero";
                    break;
                case 1:
                    retorno = "x é um";
                    break;
                case 2:
                    retorno = "x é dois";
                    break;
                case 3:
                    retorno = "x é três";
                    break;
                default:
                    retorno = "x é algum número não previsto";
                    break;
            }

            return retorno;
        }

        [HttpGet]
        public string GetFor()
        {
            string retorno = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                retorno += $"{i};";
            }

            return retorno;
        }

        [HttpGet]
        public string GetDayOfWeek(int day)
        {
            string retorno;

            switch (day)
            {
                case 0:
                    retorno = "Domingo";
                    break;
                case 1:
                    retorno = "Segunda-feira";
                    break;
                case 2:
                    retorno = "Terça-feira";
                    break;
                case 3:
                    retorno = "Quarta-feira";
                    break;
                case 4:
                    retorno = "Quinta-feira";
                    break;
                case 5:
                    retorno = "Sexta-feira";
                    break;
                case 6:
                    retorno = "Sábado";
                    break;
                default:
                    retorno = "Número inválido. Por favor, insira um número de 0 a 6.";
                    break;
            }

            return retorno;
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
    }
}