using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
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
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult consultar_cliente()
        {
            return View();
        }
        public IActionResult consultar_funcionario()
        {
            return View();
        }
        public IActionResult consultar_materiais()
        {
            return View();
        }
        public IActionResult consultar_pedido()
        {
            return View();
        }
        public IActionResult consultar_servico()
        {
            return View();
        }
        public IActionResult consultar_fornecedor()
        {
            return View();
        }

        public IActionResult inserir_cliente()
        {
            return View();
        }
        public IActionResult inserir_funcionario()
        {
            return View();
        }
        public IActionResult inserir_materiais()
        {
            return View();
        }
        public IActionResult inserir_pedido()
        {
            return View();
        }
        public IActionResult inserir_orcamento()
        {
            return View();
        }
        public IActionResult inserir_servico()
        {
            return View();
        }
        public IActionResult inserir_fornecedor()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
        public IActionResult mensalista()
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
