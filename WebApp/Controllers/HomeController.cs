using Microsoft.AspNetCore.Mvc;
using Module.Security.Infraestructure.Interfaces.Client;
using System.Diagnostics;
using WebApp.Models;
using WebAPP.Filters;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAutenticacionClient _autenticacionClient;

        public HomeController(ILogger<HomeController> logger, IAutenticacionClient autenticacionClient)
        {
            _logger = logger;
            _autenticacionClient = autenticacionClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [AuthorizationFilter]
        public IActionResult EnConstruccion()
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