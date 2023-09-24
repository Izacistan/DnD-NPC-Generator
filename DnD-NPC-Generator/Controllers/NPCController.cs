using Microsoft.AspNetCore.Mvc;

namespace DnD_NPC_Generator.Controllers
{
    public class NPCController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}
