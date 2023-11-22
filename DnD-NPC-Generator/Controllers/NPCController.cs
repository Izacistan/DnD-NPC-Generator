﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using DnD_NPC_Generator.Models;
using DnD_NPC_Generator.Sessions;
using DnD_NPC_Generator.Services;
using Microsoft.EntityFrameworkCore;
using DnD_NPC_Generator.Repository;

namespace DnD_NPC_Generator.Controllers
{
    public class NPCController : Controller
    {
        private ILegionRepository legion { get; set; }

        public NPCController(ILegionRepository legion) => this.legion = legion;

        [HttpGet]
        public IActionResult Index()
        {
            var model = new NPCListView()
            {
                NPCs = this.legion.GetAllNpcs()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Classes = this.legion.GetAllClasses();
            ViewBag.Races = this.legion.GetAllRaces();
            return View("Edit", new NPC());
        }

        [HttpGet]
        public IActionResult Generate(string classChoice, string statChoice)
        {
            var service = new NPCService();
            var npc = new NPC();
            ViewBag.Classes = this.legion.GetAllClasses();
            ViewBag.Races = this.legion.GetAllRaces();
            service.GenerateNPC(ref npc, ViewBag.Classes, classChoice, statChoice);
            ViewBag.Action = "Generate";

            return View("Edit", npc);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Classes = this.legion.GetAllClasses();
            ViewBag.Races = this.legion.GetAllRaces();
            var NPC = this.legion.FindNpc(id);
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
                    this.legion.AddNpc(npc);
                }
                else
                {
                    this.legion.UpdateNpc(npc);
                }
                this.legion.Save();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Action = (npc.NPCId == 0) ? "Add" : "Edit";
                ViewBag.Classes = this.legion.GetAllClasses();
                ViewBag.Races = this.legion.GetAllRaces();
                return View(npc);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var npc = this.legion.FindNpc(id);
            return View(npc);
        }

        [HttpPost]
        public IActionResult Delete(NPC npc)
        {
            this.legion.DeleteNpc(npc);
            this.legion.Save();
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

        public IActionResult User()
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
            NPC character = this.legion.GetNpc(npc.NPCId);

            var session = new NPCSession(HttpContext.Session);
            var npcs = session.GetViewNPCs();
            npcs.Add(character);
            session.SetViewNPCs(npcs);

            TempData["Message"] = $"{character.Name} added to View List!";

            return RedirectToAction("Index");
        }
    }
}
