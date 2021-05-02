using AspNetCoreMvcProject.DAL;
using AspNetCoreMvcProject.Models;
using FrontToBack.Extensions;
using FrontToBack.Helpers;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles = "Admin")]

    public class AboutCourseController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly Database _db;
        public AboutCourseController(Database db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.AboutCourses);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AboutCourse aboutCourse)
        {

            if (ModelState["File"].ValidationState == ModelValidationState.Invalid)
            {
                ModelState.AddModelError("", "Please choose image !");
                return View();
            }

            if (!aboutCourse.File.IsImage())
            {
                ModelState.AddModelError("File", $"In this {aboutCourse.File.FileName} name file format not correct !");
                return View();
            }

            if (aboutCourse.File.CheckFileSize(2000))
            {
                ModelState.AddModelError("File", $" In this {aboutCourse.File.FileName} name file size is greater than 150 kb !");
                return View();
            }
            string folder = Path.Combine("img", "about");

            aboutCourse.Image = await aboutCourse.File.SaveFileAsync(_env.WebRootPath, folder);

            await _db.AboutCourses.AddAsync(aboutCourse);

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            AboutCourse about = await _db.AboutCourses.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (about == null) return NotFound();
            return View(about);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            AboutCourse about = await _db.AboutCourses.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (about == null) return NotFound();
            return View(about);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, AboutCourse aboutCourse)
        {
            if (id == null) return NotFound();
            AboutCourse dbAboutCourse = await _db.AboutCourses.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (dbAboutCourse == null) return NotFound();

            if (ModelState["File"].ValidationState == ModelValidationState.Invalid)
            {
                ModelState.AddModelError("", "Please choose image !");
                return View();
            }

            if (!aboutCourse.File.IsImage())
            {
                ModelState.AddModelError("File", $"In this {aboutCourse.File.FileName} name file format not correct !");
                return View();
            }

            if (aboutCourse.File.CheckFileSize(2000))
            {
                ModelState.AddModelError("File", $" In this {aboutCourse.File.FileName} name file size is greater than 150 kb !");
                return View();
            }

            string folder = Path.Combine("img", "about");

            Helper.DeleteFile(_env.WebRootPath, folder, dbAboutCourse.Image);

            dbAboutCourse.Heading = aboutCourse.Heading;
            dbAboutCourse.Description = aboutCourse.Description;
            dbAboutCourse.Image = await aboutCourse.File.SaveFileAsync(_env.WebRootPath, folder);

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            AboutCourse about = await _db.AboutCourses.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (about == null) return NotFound();
            return View(about);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteAboutCourse(int? id)
        {
            if (id == null) return NotFound();
            AboutCourse dbAboutCourse = await _db.AboutCourses.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (dbAboutCourse == null) return NotFound();
            string folder = Path.Combine("img", "about");

            Helper.DeleteFile(_env.WebRootPath, folder, dbAboutCourse.Image);

            dbAboutCourse.IsDeleted = true;
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
