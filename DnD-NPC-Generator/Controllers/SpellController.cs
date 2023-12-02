﻿using DnD_NPC_Generator.Models;
using DnD_NPC_Generator.WebAPI;
using Microsoft.AspNetCore.Mvc;

namespace DnD_NPC_Generator.Controllers
{
    public class SpellController : Controller
    {
        private readonly DNDConsumer consumer;

        public SpellController(DNDConsumer consumer)
        {
            this.consumer = consumer;
        }

        public async Task<IActionResult> Index()
        {
            SpellListView spellList = new SpellListView();
            spellList.Spells = await consumer.GetAllSpells();

            return View(spellList);
        }

        public async Task<IActionResult> Test(string id = "cleric")
        {
            return Ok(await consumer.GetSpellsByClass(id));
        }
    }
}