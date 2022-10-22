using ColorDisenho.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ColorDisenho.Controllers
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

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult MenuAdmin()
        {
            return View();
        }

        public IActionResult CrearEmpleado()
        {
            return View();
        }

        public IActionResult ActualizarProduccion()
        {
            return View();
        }

        public IActionResult Insumos()
        {
            return View();
        }

        public IActionResult MenuUsuario()
        {
            return View();
        }

        public IActionResult CrearPedido()
        {
            return View();
        }
        public IActionResult CancelarPedido()
        {
            return View();
        }

        public IActionResult GenerarReportesStock()
        {
            return View();
        }

        public IActionResult ModificarPedido()
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