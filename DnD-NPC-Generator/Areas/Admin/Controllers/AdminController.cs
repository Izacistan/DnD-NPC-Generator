using DnD_NPC_Generator.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json.Linq;


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
            ViewBag.UserNameList = GetAllUserNames(npcList);

            return View(npcListView);
        }

        public List<NPC> GetAllNpcs()
        {
            return context.NPCs.Include(n => n.NPCClass).Include(n => n.NPCRace).OrderBy(c => c.NPCId).ToList();
        }

        public List<string> GetAllUserNames(List<NPC> npcList)
        {
            List<string> usernames = new List<string>();
            foreach (var npc in npcList)
            {
                string username = context.Users.Where(u => u.Id == npc.Owner).ToList()[0].UserName;
                usernames.Add(username);
            }

            return usernames;
        }
    }
}
