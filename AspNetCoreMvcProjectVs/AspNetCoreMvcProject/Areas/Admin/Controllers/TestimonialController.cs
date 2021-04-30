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
    public class TestimonialController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly Database _db;
        public TestimonialController(Database db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.Testimonials);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Testimonial testimonial)
        {

            if (ModelState["File"].ValidationState == ModelValidationState.Invalid)
            {
                ModelState.AddModelError("", "Please choose image !");
                return View();
            }

            if (!testimonial.File.IsImage())
            {
                ModelState.AddModelError("File", $"In this {testimonial.File.FileName} name file format not correct !");
                return View();
            }

            if (testimonial.File.CheckFileSize(2000))
            {
                ModelState.AddModelError("File", $" In this {testimonial.File.FileName} name file size is greater than 150 kb !");
                return View();
            }
            string folder = Path.Combine("img", "testimonial");

            testimonial.Image = await testimonial.File.SaveFileAsync(_env.WebRootPath, folder);

            await _db.Testimonials.AddAsync(testimonial);

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            Testimonial testimonial = await _db.Testimonials.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (testimonial == null) return NotFound();
            return View(testimonial);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Testimonial testimonial = await _db.Testimonials.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (testimonial == null) return NotFound();
            return View(testimonial);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Testimonial testimonial)
        {
            if (id == null) return NotFound();
            Testimonial dbTestimonial = await _db.Testimonials.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (dbTestimonial == null) return NotFound();

            if (ModelState["File"].ValidationState == ModelValidationState.Invalid)
            {
                ModelState.AddModelError("", "Please choose image !");
                return View();
            }

            if (!dbTestimonial.File.IsImage())
            {
                ModelState.AddModelError("File", $"In this {dbTestimonial.File.FileName} name file format not correct !");
                return View();
            }

            if (dbTestimonial.File.CheckFileSize(2000))
            {
                ModelState.AddModelError("File", $" In this {dbTestimonial.File.FileName} name file size is greater than 150 kb !");
                return View();
            }

            string folder = Path.Combine("img", "testimonial");

            Helper.DeleteFile(_env.WebRootPath, folder, dbTestimonial.Image);

            dbTestimonial.FullName = testimonial.FullName;
            dbTestimonial.Description = testimonial.Description;
            dbTestimonial.Profession = testimonial.Profession;
            dbTestimonial.Image = await dbTestimonial.File.SaveFileAsync(_env.WebRootPath, folder);

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Testimonial testimonial = await _db.Testimonials.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (testimonial == null) return NotFound();
            return View(testimonial);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteTestimonial(int? id)
        {
            if (id == null) return NotFound();
            Testimonial dbTestimonial = await _db.Testimonials.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (dbTestimonial == null) return NotFound();
            string folder = Path.Combine("img", "testimonial");

            Helper.DeleteFile(_env.WebRootPath, folder, dbTestimonial.Image);

            dbTestimonial.IsDeleted = true;
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
