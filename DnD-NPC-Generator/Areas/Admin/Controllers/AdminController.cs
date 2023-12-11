using DnD_NPC_Generator.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace DnD_NPC_Generator.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly NPCContext context;

        public AdminController(NPCContext dbContext)
        {
            context = dbContext;
        }

        [Area("Admin")]
        public IActionResult Index()
        {
            var npcList = GetAllNpcs();
            var npcListView = new NPCListView { NPCs = npcList };
            return View(npcListView);
        }

        public List<NPC> GetAllNpcs()
        {
            return context.NPCs.Include(n => n.NPCClass).Include(n => n.NPCRace).OrderBy(c => c.NPCId).ToList();
        }
    }
}
