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

    public class TeacherController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly Database _db;
        public TeacherController(Database db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index(int? page)
        {
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Teachers.Count() / 8);

            if (page == null)
            {
                ViewBag.Page = 1;
                return View(_db.Teachers.OrderByDescending(p => p.Id).Take(8).ToList());
            }
            else
            {
                ViewBag.Page = page;
                return View(_db.Teachers.OrderByDescending(p => p.Id).Skip(((int)page - 1) * 8).Take(8).ToList());
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Teacher teacher)
        {
            if (ModelState["File"].ValidationState == ModelValidationState.Invalid)
            {
                ModelState.AddModelError("", "Please choose image !");
                return View();
            }

            if (!teacher.File.IsImage())
            {
                ModelState.AddModelError("File", $"In this {teacher.File.FileName} name file format not correct !");
                return View();
            }

            if (teacher.File.CheckFileSize(2000))
            {
                ModelState.AddModelError("File", $" In this {teacher.File.FileName} name file size is greater than 150 kb !");
                return View();
            }
            string folder = Path.Combine("img", "teacher");

            teacher.Image = await teacher.File.SaveFileAsync(_env.WebRootPath, folder);

            await _db.Teachers.AddAsync(teacher);

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            Teacher teacher = await _db.Teachers.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (teacher == null) return NotFound();
            return View(teacher);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Teacher teacher = await _db.Teachers.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (teacher == null) return NotFound();
            return View(teacher);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Teacher teacher)
        {
            if (id == null) return NotFound();
            Teacher dbTeacher = await _db.Teachers.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (dbTeacher == null) return NotFound();

            if (ModelState["File"].ValidationState == ModelValidationState.Invalid)
            {
                ModelState.AddModelError("", "Please choose image !");
                return View();
            }

            if (!teacher.File.IsImage())
            {
                ModelState.AddModelError("File", $"In this {teacher.File.FileName} name file format not correct !");
                return View();
            }

            if (teacher.File.CheckFileSize(2000))
            {
                ModelState.AddModelError("File", $" In this {teacher.File.FileName} name file size is greater than 150 kb !");
                return View();
            }

            string folder = Path.Combine("img", "teacher");

            Helper.DeleteFile(_env.WebRootPath, folder, dbTeacher.Image);

            dbTeacher.FullName = teacher.FullName;
            dbTeacher.Profession = teacher.Profession;
            dbTeacher.About = teacher.About;
            dbTeacher.Degree = teacher.Degree;
            dbTeacher.Experience = teacher.Experience;
            dbTeacher.Hobbies = teacher.Hobbies;
            dbTeacher.Faculty = teacher.Faculty ;
            dbTeacher.ContactInfoMail = teacher.ContactInfoMail;
            dbTeacher.ContactInfoSkype = teacher.ContactInfoSkype;
            dbTeacher.ContactInfoNumber = teacher.ContactInfoNumber;
            dbTeacher.OwnFacebook = teacher.OwnFacebook;
            dbTeacher.OwnPinterest = teacher.OwnPinterest;
            dbTeacher.OwnVimeo = teacher.OwnVimeo;
            dbTeacher.OwnTwitter = teacher.OwnTwitter;
            dbTeacher.Image = await teacher.File.SaveFileAsync(_env.WebRootPath, folder);

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Teacher teacher = await _db.Teachers.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (teacher == null) return NotFound();
            return View(teacher);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteTeacher(int? id)
        {
            if (id == null) return NotFound();
            Teacher dbTeacher = await _db.Teachers.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (dbTeacher == null) return NotFound();
            string folder = Path.Combine("img", "teacher");

            Helper.DeleteFile(_env.WebRootPath, folder, dbTeacher.Image);

            dbTeacher.IsDeleted = true;
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
