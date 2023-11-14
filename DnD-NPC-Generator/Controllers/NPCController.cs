using Microsoft.AspNetCore.Mvc;
using DnD_NPC_Generator.Models;
using DnD_NPC_Generator.Sessions;
using DnD_NPC_Generator.Services;
using Microsoft.EntityFrameworkCore;

namespace DnD_NPC_Generator.Controllers
{
    public class NPCController : Controller
    {
        private NPCContext context { get; set; }

        public NPCController(NPCContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Index()
        {
            var model = new NPCListView()
            {
                NPCs = context.NPCs.Include(n => n.NPCClass).Include(n => n.NPCRace).OrderBy(c => c.NPCId).ToList()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Classes = context.NPCClasses.OrderBy(c => c.NPCClassId).ToList();
            ViewBag.Races = context.NPCRaces.OrderBy(r => r.NPCRaceId).ToList();
            return View("Edit", new NPC());
        }

        [HttpGet]
        public IActionResult Generate(string classChoice, string statChoice)
        {
            var service = new NPCService();
            var npc = new NPC();
            ViewBag.Classes = context.NPCClasses.OrderBy(c => c.NPCClassId).ToList();
            ViewBag.Races = context.NPCRaces.OrderBy(r => r.NPCRaceId).ToList();
            service.GenerateNPC(ref npc, ViewBag.Classes, classChoice, statChoice);
            ViewBag.Action = "Generate";

            return View("Edit", npc);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Classes = context.NPCClasses.OrderBy(c => c.NPCClassId).ToList();
            ViewBag.Races = context.NPCRaces.OrderBy(r => r.NPCRaceId).ToList();
            var NPC = context.NPCs.Find(id);
            return View(NPC);
        }

        [HttpPost]
        public IActionResult Edit(NPC npc)
        {
            //noticed npc service so added it here please use the service as needed -Halmar
            var service = new NPCService();
            //service funcions
            service.SetProficiencyMod(ref npc);

            if (ModelState.IsValid)
            {
                if (npc.NPCId == 0)
                {
                    context.NPCs.Add(npc);
                }
                else
                {
                    context.NPCs.Update(npc);
                }
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Action = (npc.NPCId == 0) ? "Add" : "Edit";
                ViewBag.Classes = context.NPCClasses.OrderBy(c => c.NPCClassId).ToList();
                ViewBag.Races = context.NPCRaces.OrderBy(r => r.NPCRaceId).ToList();
                return View(npc);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var npc = context.NPCs.Find(id);
            return View(npc);
        }

        [HttpPost]
        public IActionResult Delete(NPC npc)
        {
            context.NPCs.Remove(npc);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Display()
        {
            //Get all NPCs from session
            var session = new NPCSession(HttpContext.Session);
            var model = new NPCListView()
            {
                NPCs = session.GetViewNPCs()
            };

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Add(NPC npc)
        {
            NPC character = context.NPCs.Where(n => n.NPCId == npc.NPCId).FirstOrDefault();

            var session = new NPCSession(HttpContext.Session);
            var npcs = session.GetViewNPCs();
            npcs.Add(character);
            session.SetViewNPCs(npcs);

            TempData["Message"] = $"{character.Name} added to View List!";

            return RedirectToAction("Index");
        }
    }
}
