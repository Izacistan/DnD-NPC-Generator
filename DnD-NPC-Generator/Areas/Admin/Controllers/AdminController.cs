using Microsoft.AspNetCore.Mvc;

namespace DnD_NPC_Generator.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
