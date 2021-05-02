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
    [Authorize(Roles = "Admin,Teacher")]

    public class CourseController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly Database _db;
        public CourseController(Database db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index(int? page)
        {
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Courses.Count() / 8);

            if (page == null)
            {
                ViewBag.Page = 1;
                return View(_db.Courses.OrderByDescending(p => p.Id).Take(8));
            }
            else
            {
                ViewBag.Page = page;
                return View(_db.Courses.OrderByDescending(p => p.Id).Skip(((int)page - 1) * 8).Take(8));
            }
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Course course)
        {
            if (!(await _db.Courses.AnyAsync(c => c.IsDeleted == false && c.CourseName.ToLower().Trim() == course.CourseName.ToLower().Trim())))
            {
                ModelState.AddModelError("CourseName", "This name already exist !");
                return View();
            }
            if (ModelState["File"].ValidationState == ModelValidationState.Invalid)
            {
                ModelState.AddModelError("", "Please choose image !");
                return View();
            }

            if (!course.File.IsImage())
            {
                ModelState.AddModelError("File", $"In this {course.File.FileName} name file format not correct !");
                return View();
            }

            if (course.File.CheckFileSize(2000))
            {
                ModelState.AddModelError("File", $" In this {course.File.FileName} name file size is greater than 150 kb !");
                return View();
            }

            course.Image = await course.File.SaveFileAsync(_env.WebRootPath, "img/course");

            await _db.Courses.AddAsync(course);

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            Course course = await _db.Courses.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (course == null) return NotFound();
            return View(course);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Course course = await _db.Courses.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (course == null) return NotFound();
            return View(course);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Course course)
        {
            if (id == null) return NotFound();
            Course dbCourse = await _db.Courses.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (dbCourse == null) return NotFound();

            if (await _db.Courses.AnyAsync(c => c.IsDeleted == false && c.CourseName.ToLower().Trim() == course.CourseName.ToLower().Trim() && c.Id==course.Id))
            {
                ModelState.AddModelError("CourseName", "This name already exist !");
                return View();
            }
            if (ModelState["File"].ValidationState == ModelValidationState.Invalid)
            {
                ModelState.AddModelError("", "Please choose image !");
                return View();
            }

            if (!course.File.IsImage())
            {
                ModelState.AddModelError("File", $"In this {course.File.FileName} name file format not correct !");
                return View();
            }

            if (course.File.CheckFileSize(2000))
            {
                ModelState.AddModelError("File", $" In this {course.File.FileName} name file size is greater than 150 kb !");
                return View();
            }

            string folder = Path.Combine("img", "course");

            Helper.DeleteFile(_env.WebRootPath, folder, dbCourse.Image);

            dbCourse.AboutCourse = course.AboutCourse;
            dbCourse.Assesments = course.Assesments;
            dbCourse.Certification = course.Certification;
            dbCourse.ClassDuration = course.ClassDuration;
            dbCourse.Duration = course.Duration;
            dbCourse.CourseContent = course.CourseContent;
            dbCourse.AboutCourse = course.AboutCourse;
            dbCourse.HowToApply = course.HowToApply;
            dbCourse.Language = course.Language;
            dbCourse.Price = course.Price;
            dbCourse.SkillLevel = course.SkillLevel;
            dbCourse.StartDate = course.StartDate;
            dbCourse.StudentsCount = course.StudentsCount;
            dbCourse.CourseName = course.CourseName;
            dbCourse.Image = await course.File.SaveFileAsync(_env.WebRootPath, folder);

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Course course = await _db.Courses.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (course == null) return NotFound();
            return View(course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCourse(int? id)
        {
            if (id == null) return NotFound();
            Course dbCourse = await _db.Courses.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (dbCourse == null) return NotFound();
            string folder = Path.Combine("img", "course");

            Helper.DeleteFile(_env.WebRootPath, folder, dbCourse.Image);

            dbCourse.IsDeleted = true;
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
