using AspNetCoreMvcProject.DAL;
using AspNetCoreMvcProject.Models;
using FrontToBack.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NoticeController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly Database _db;
        public NoticeController(Database db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.Notices);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Notice notice)
        {
            if (!ModelState.IsValid) return View();

            await _db.Notices.AddAsync(notice);

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            Notice notice = await _db.Notices.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (notice == null) return NotFound();
            return View(notice);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Notice notice = await _db.Notices.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (notice == null) return NotFound();
            return View(notice);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Notice notice)
        {
            if (id == null) return NotFound();
            Notice dbNotice = await _db.Notices.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (dbNotice == null) return NotFound();

            dbNotice.VideoLink = notice.VideoLink;
            dbNotice.NoticeDate = notice.NoticeDate;
            dbNotice.NoticeText = notice.NoticeText;

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Notice notice = await _db.Notices.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (notice == null) return NotFound();
            return View(notice);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteNotice(int? id)
        {
            if (id == null) return NotFound();
            Notice dbNotice = await _db.Notices.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (dbNotice == null) return NotFound();

            dbNotice.IsDeleted = true;
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
