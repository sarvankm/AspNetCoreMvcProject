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

    public class BlogController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly Database _db;
        public BlogController(Database db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index(int? page)
        {
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Blogs.Count() / 8);

            if (page == null)
            {
                ViewBag.Page = 1;
                return View(_db.Blogs.OrderByDescending(p => p.Id).Take(8));
            }
            else
            {
                ViewBag.Page = page;
                return View(_db.Blogs.OrderByDescending(p => p.Id).Skip(((int)page - 1) * 8).Take(8));
            }
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            if (await _db.Blogs.AnyAsync(b => b.IsDeleted == false && b.Name.ToLower().Trim() == blog.Name.ToLower().Trim()))
            {
                ModelState.AddModelError("Name", "This name already exist !");
                return View();
            }
            if (ModelState["File"].ValidationState == ModelValidationState.Invalid)
            {
                ModelState.AddModelError("", "Please choose image !");
                return View();
            }

            if (!blog.File.IsImage())
            {
                ModelState.AddModelError("File", $"In this {blog.File.FileName} name file format not correct !");
                return View();
            }

            if (blog.File.CheckFileSize(2000))
            {
                ModelState.AddModelError("File", $" In this {blog.File.FileName} name file size is greater than 150 kb !");
                return View();
            }
            string folder = Path.Combine("img", "event");

            blog.Image = await blog.File.SaveFileAsync(_env.WebRootPath, folder);

            await _db.Blogs.AddAsync(blog);

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = await _db.Blogs.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (blog == null) return NotFound();
            return View(blog);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = await _db.Blogs.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (blog == null) return NotFound();
            return View(blog);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Blog blog)
        {
            if (id == null) return NotFound();
            Blog dbBlog = await _db.Blogs.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (dbBlog == null) return NotFound();


            if (await _db.Blogs.AnyAsync(b => b.IsDeleted == false && b.Name.ToLower().Trim() == blog.Name.ToLower().Trim() && b.Id==blog.Id))
            {
                ModelState.AddModelError("Name", "This name already exist !");
                return View();
            }
            if (ModelState["File"].ValidationState == ModelValidationState.Invalid)
            {
                ModelState.AddModelError("", "Please choose image !");
                return View();
            }

            if (!blog.File.IsImage())
            {
                ModelState.AddModelError("File", $"In this {blog.File.FileName} name file format not correct !");
                return View();
            }

            if (blog.File.CheckFileSize(2000))
            {
                ModelState.AddModelError("File", $" In this {blog.File.FileName} name file size is greater than 150 kb !");
                return View();
            }

            string folder = Path.Combine("img", "blog");

            Helper.DeleteFile(_env.WebRootPath, folder, dbBlog.Image);

            dbBlog.Name = blog.Name;
            dbBlog.Date = blog.Date;
            dbBlog.BlogContent = blog.BlogContent;
            dbBlog.Description = blog.Description;
           
            dbBlog.Image = await blog.File.SaveFileAsync(_env.WebRootPath, folder);

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = await _db.Blogs.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (blog == null) return NotFound();
            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteBlog(int? id)
        {
            if (id == null) return NotFound();
            Blog dbBlog = await _db.Blogs.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (dbBlog == null) return NotFound();
            string folder = Path.Combine("img", "blog");

            Helper.DeleteFile(_env.WebRootPath, folder, dbBlog.Image);

            dbBlog.IsDeleted = true;
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
