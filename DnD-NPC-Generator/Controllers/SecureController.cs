using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DnD_NPC_Generator.Controllers
{
    public class SecureController : Controller
    {
        public SecureController() 
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult User()
        {
            return View(); 
        }


    }
}
