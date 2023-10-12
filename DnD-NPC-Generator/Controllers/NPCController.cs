using Microsoft.AspNetCore.Mvc;
using DnD_NPC_Generator.Models;

namespace DnD_NPC_Generator.Controllers
{
    public class NPCController : Controller
    {
        private NPCContext context { get; set; }

        public NPCController(NPCContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Index()
        {
            var NPCs = context.NPCs.OrderBy(c => c.NPCId).ToList();
            return View(NPCs);
        }

        [HttpGet]
        public IActionResult Generate()
        {
            ViewBag.Action = "Generate";
            return View("Edit", new NPC());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var NPC = context.NPCs.Find(id);
            return View(NPC);
        }

        [HttpPost]
        public IActionResult Edit(NPC npc)
        {
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
            //Next line should be coming from session storage
            List<NPC> NPCs = context.NPCs.ToList();
            NPCView nPCView = new NPCView();
            nPCView.NPCs = NPCs;

            return View(nPCView);
        }
    }
}
