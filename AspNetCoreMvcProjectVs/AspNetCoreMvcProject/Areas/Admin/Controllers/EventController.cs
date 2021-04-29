using AspNetCoreMvcProject.DAL;
using AspNetCoreMvcProject.Models;
using FrontToBack.Extensions;
using FrontToBack.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EventController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly Database _db;
        public EventController(Database db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.Events);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Event events)
        {
            if (await _db.Events.AnyAsync(c => c.IsDeleted == false && c.EventName.ToLower().Trim() == events.EventName.ToLower().Trim() && c.Id == events.Id))
            {
                ModelState.AddModelError("EventName", "This name already exist !");
                return View();
            }
            if (ModelState["File"].ValidationState == ModelValidationState.Invalid)
            {
                ModelState.AddModelError("", "Please choose image !");
                return View();
            }

            if (!events.File.IsImage())
            {
                ModelState.AddModelError("File", $"In this {events.File.FileName} name file format not correct !");
                return View();
            }

            if (events.File.CheckFileSize(2000))
            {
                ModelState.AddModelError("File", $" In this {events.File.FileName} name file size is greater than 150 kb !");
                return View();
            }
            string folder = Path.Combine("img", "event");

            events.Image = await events.File.SaveFileAsync(_env.WebRootPath, folder);

            await _db.Events.AddAsync(events);

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            Event events = await _db.Events.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (events == null) return NotFound();
            return View(events);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Event events = await _db.Events.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (events == null) return NotFound();
            return View(events);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Event events)
        {
            if (id == null) return NotFound();
            Event dbEvent = await _db.Events.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (dbEvent == null) return NotFound();


            if (!(await _db.Events.AnyAsync(c => c.IsDeleted == false && c.EventName.ToLower().Trim() == events.EventName.ToLower().Trim())))
            {
                ModelState.AddModelError("CourseName", "This name already exist !");
                return View();
            }
            if (ModelState["File"].ValidationState == ModelValidationState.Invalid)
            {
                ModelState.AddModelError("", "Please choose image !");
                return View();
            }

            if (!events.File.IsImage())
            {
                ModelState.AddModelError("File", $"In this {events.File.FileName} name file format not correct !");
                return View();
            }

            if (events.File.CheckFileSize(2000))
            {
                ModelState.AddModelError("File", $" In this {events.File.FileName} name file size is greater than 150 kb !");
                return View();
            }

            string folder = Path.Combine("img", "event");

            Helper.DeleteFile(_env.WebRootPath, folder, dbEvent.Image);

            dbEvent.EventName = events.EventName;
            dbEvent.EndTime = events.EndTime;
            dbEvent.EventContent = events.EventContent;
            dbEvent.StartDateDayMonth = events.StartDateDayMonth;
            dbEvent.StartTime = events.StartTime;
            dbEvent.Venue = events.Venue;
            dbEvent.Image = await events.File.SaveFileAsync(_env.WebRootPath, folder);

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Event events = await _db.Events.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (events == null) return NotFound();
            return View(events);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteEvent(int? id)
        {
            if (id == null) return NotFound();
            Event dbEvent = await _db.Events.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (dbEvent == null) return NotFound();
            string folder = Path.Combine("img", "event");

            Helper.DeleteFile(_env.WebRootPath, folder, dbEvent.Image);

            dbEvent.IsDeleted = true;
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
} 

