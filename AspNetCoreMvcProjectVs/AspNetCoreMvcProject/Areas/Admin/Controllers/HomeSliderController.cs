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
using System.IO;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class HomeSliderController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly Database _db;
        public HomeSliderController(Database db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.HomeSliders);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HomeSlider homeSlider)
        {

            if (ModelState["File"].ValidationState == ModelValidationState.Invalid)
            {
                ModelState.AddModelError("", "Please choose image !");
                return View();
            }

            if (!homeSlider.File.IsImage())
            {
                ModelState.AddModelError("File", $"In this {homeSlider.File.FileName} name file format not correct !");
                return View();
            }

            if (homeSlider.File.CheckFileSize(2000))
            {
                ModelState.AddModelError("File", $" In this {homeSlider.File.FileName} name file size is greater than 150 kb !");
                return View();
            }
            string folder = Path.Combine("img", "slider");

            homeSlider.Image = await homeSlider.File.SaveFileAsync(_env.WebRootPath, folder);

            await _db.HomeSliders.AddAsync(homeSlider);

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            HomeSlider homeSlider = await _db.HomeSliders.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (homeSlider == null) return NotFound();
            return View(homeSlider);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            HomeSlider homeSlider = await _db.HomeSliders.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (homeSlider == null) return NotFound();
            return View(homeSlider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, HomeSlider homeSlider)
        {
            if (id == null) return NotFound();
            HomeSlider dbHomeSlider = await _db.HomeSliders.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (dbHomeSlider == null) return NotFound();

            if (ModelState["File"].ValidationState == ModelValidationState.Invalid)
            {
                ModelState.AddModelError("", "Please choose image !");
                return View();
            }

            if (!dbHomeSlider.File.IsImage())
            {
                ModelState.AddModelError("File", $"In this {dbHomeSlider.File.FileName} name file format not correct !");
                return View();
            }

            if (dbHomeSlider.File.CheckFileSize(2000))
            {
                ModelState.AddModelError("File", $" In this {dbHomeSlider.File.FileName} name file size is greater than 150 kb !");
                return View();
            }

            string folder = Path.Combine("img", "slider");

            Helper.DeleteFile(_env.WebRootPath, folder, dbHomeSlider.Image);

            dbHomeSlider.Title = homeSlider.Title;
            dbHomeSlider.Description = homeSlider.Description;
            dbHomeSlider.Image = await dbHomeSlider.File.SaveFileAsync(_env.WebRootPath, folder);

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            HomeSlider homeSlider = await _db.HomeSliders.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (homeSlider == null) return NotFound();
            return View(homeSlider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteHomeSlider(int? id)
        {
            if (id == null) return NotFound();
            HomeSlider dbHomeSlider = await _db.HomeSliders.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (dbHomeSlider == null) return NotFound();
            string folder = Path.Combine("img", "slider");

            Helper.DeleteFile(_env.WebRootPath, folder, dbHomeSlider.Image);

            dbHomeSlider.IsDeleted = true;
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
