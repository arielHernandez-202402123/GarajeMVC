using System.Diagnostics;
using GarajeMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace GarajeMVC.Controllers
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
            // Datos de ejemplo: Ingresamos algunos autos al garaje

            miGaraje.ingresarAuto(new Auto(1, "Toyota", "HAG3034"));
            miGaraje.ingresarAuto(new Auto(2, "Ford", "HAZ8990"));
            miGaraje.ingresarAuto(new Auto(3, "Hyundai", "HCB2019"));

            return View(miGaraje);
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

        // Instancia del objeto miGaraje
        private Garage miGaraje = new Garage(1, "Carlos Ariel Hernandez Sanchez", 10, 0);


    }
}
