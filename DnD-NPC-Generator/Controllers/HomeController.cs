using DnD_NPC_Generator.Models;
using DnD_NPC_Generator.Services;
using DnD_NPC_Generator.WebAPI;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DnD_NPC_Generator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private NPCContext context { get; set; }

        public HomeController(ILogger<HomeController> logger, NPCContext context)
        {
            _logger = logger;
            this.context = context;
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}