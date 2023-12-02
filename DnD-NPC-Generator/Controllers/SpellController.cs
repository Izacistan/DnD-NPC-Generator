using DnD_NPC_Generator.Models;
using DnD_NPC_Generator.Repository;
using DnD_NPC_Generator.WebAPI;
using Microsoft.AspNetCore.Mvc;

namespace DnD_NPC_Generator.Controllers
{
    public class SpellController : Controller
    {
        private readonly DNDConsumer consumer;
        private readonly ILegionRepository legion;

        public SpellController(DNDConsumer consumer, ILegionRepository legion)
        {
            this.consumer = consumer;
            this.legion = legion;
        }

        public async Task<IActionResult> Index()
        {
            SpellListView spellList = new SpellListView();
            spellList.Spells = await consumer.GetAllSpells();

            ViewBag.Classes = this.legion.GetAllClasses();
            ViewBag.Schools = new List<string> { "Abjuration", "Conjuration", "Divination", "Enchantment", "Evocation", "Illusion", "Necromancy", "Transmutation" };

            return View(spellList);
        }

        public async Task<IActionResult> Test(string id = "cleric")
        {
            return Ok(await consumer.GetSpellsByClass(id));
        }
    }
}
