using AspNetCoreMvcProject.DAL;
using AspNetCoreMvcProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ShortInfoController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly Database _db;
        public ShortInfoController(Database db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.ShortInfos);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ShortInfo shortInfo)
        {
            if (!ModelState.IsValid) return View();

            await _db.ShortInfos.AddAsync(shortInfo);

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            ShortInfo shortInfo = await _db.ShortInfos.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (shortInfo == null) return NotFound();
            return View(shortInfo);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            ShortInfo shortInfo = await _db.ShortInfos.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (shortInfo == null) return NotFound();
            return View(shortInfo);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, ShortInfo shortInfo)
        {
            if (id == null) return NotFound();
            ShortInfo dbShortInfo = await _db.ShortInfos.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (dbShortInfo == null) return NotFound();

            dbShortInfo.Title = shortInfo.Title;
            dbShortInfo.Description = shortInfo.Description;

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            ShortInfo shortInfo = await _db.ShortInfos.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (shortInfo == null) return NotFound();
            return View(shortInfo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteShortInfo(int? id)
        {
            if (id == null) return NotFound();
            ShortInfo dbShortInfo = await _db.ShortInfos.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (dbShortInfo == null) return NotFound();

            dbShortInfo.IsDeleted = true;
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
