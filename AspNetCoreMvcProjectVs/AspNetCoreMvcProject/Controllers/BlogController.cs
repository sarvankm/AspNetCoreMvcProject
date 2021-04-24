using AspNetCoreMvcProject.DAL;
using AspNetCoreMvcProject.Models;
using AspNetCoreMvcProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AspNetCoreMvcProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly Database _db;
        public BlogController(Database db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Blog> blogs = _db.Blogs.ToList();

            List<BlogVM> blogVMs = new List<BlogVM>();
            foreach (Blog item in blogs)
            {
                blogVMs.Add(new BlogVM
                {
                    Id = item.Id,
                    Name = item.Name,
                    Date = item.Date,
                    Image = item.Image,
                    CommentCount = item.CommentCount,
                    BlogContent = item.BlogContent
                });
            }
            return View(blogVMs);
        }
        public async Task<IActionResult> BlogDetails(int? id)
        {

            return View(await _db.Blogs.Include(b => b.CommentForms).FirstOrDefaultAsync(b => b.Id == id));

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Comment(int? id, Blog Comment)
        {

            foreach (CommentForm comment in Comment.CommentForms)
            {

                if (string.IsNullOrEmpty(comment.Name))
                {
                    ModelState.AddModelError("", "The Form was't sent correctly");
                    return RedirectToAction("BlogDetails");
                }
                if (string.IsNullOrEmpty(comment.Email))
                {
                    ModelState.AddModelError("", "The Form was't sent correctly");
                    return RedirectToAction("BlogDetails");
                }
                if (string.IsNullOrEmpty(comment.Massage))
                {
                    ModelState.AddModelError("", "The Form was't sent correctly");
                    return RedirectToAction("BlogDetails");
                }
                if (string.IsNullOrEmpty(comment.Subject))
                {
                    ModelState.AddModelError("", "The Form was't sent correctly");
                    return RedirectToAction("BlogDetails");
                }
                if (id == null) return NotFound();

                Blog blog = await _db.Blogs.FindAsync(id);

                if (blog == null) return NotFound();

                blog.CommentCount++;
                comment.BlogId = (int)id;

                await _db.CommentForms.AddAsync(comment);


                await _db.SaveChangesAsync();

            }
            
                return RedirectToAction(nameof(Index));

        }
    }
}
