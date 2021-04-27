using AspNetCoreMvcProject.DAL;
using AspNetCoreMvcProject.Models;
using FrontToBack.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly Database _db;
        public CourseController(Database db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.Courses);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Course course)
        {
            Course checkCourse = await _db.Courses.FirstOrDefaultAsync(c => c.IsDeleted == false && c.CourseName == course.CourseName);

            if (checkCourse != null)
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


    }
}
