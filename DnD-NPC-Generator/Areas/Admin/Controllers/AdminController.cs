using DnD_NPC_Generator.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json.Linq;
using DnD_NPC_Generator.Repository;
using DnD_NPC_Generator.Sessions;


namespace DnD_NPC_Generator.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly NPCContext context;
        private ILegionRepository legion { get; set; }

        public AdminController(NPCContext dbContext, ILegionRepository legion)
        {
            context = dbContext;
            this.legion = legion;
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
            return legion.GetAllNpcs();
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
