using AspNetCoreMvcProject.DAL;
using AspNetCoreMvcProject.Models;
using AspNetCoreMvcProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Controllers
{
    public class CourseController : Controller
    {
        private readonly Database _db;
        public CourseController(Database db)
        {
            _db = db;
        }
        public IActionResult Index(string search, int? page)
        {
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Courses.Count() / 8);

            if (search != null)
            {
                List<Course> courses = _db.Courses.Where(c=>c.IsDeleted ==  false).ToList();

                List<CourseVM> courseVMs = new List<CourseVM>();
                foreach (Course item in courses)
                {
                        courseVMs.Add(new CourseVM
                        {
                            Id = item.Id,
                            CourseName = item.CourseName,
                            Image = item.Image,
                            CourseContent = item.CourseContent
                        });
                }
             
                if (page == null)
                {
                    ViewBag.Page = 1;
                    IEnumerable<CourseVM> model = courseVMs
                    .Where(b => b.CourseName.ToLower().Contains(search.ToLower()))
                    .OrderByDescending(c => c.Id).Take(8);
                    return View(model);

                }
                else
                {
                    ViewBag.Page = page;
                    IEnumerable<CourseVM> model = courseVMs
                    .Where(b => b.CourseName.ToLower().Contains(search.ToLower()))
                    .OrderByDescending(c => c.Id).Skip(((int)page - 1) * 8).Take(8);
                    return View(model);
                }
            }
            else
            {
                List<Course> courses = _db.Courses.Where(c=>c.IsDeleted == false).ToList();

                List<CourseVM> courseVMs = new List<CourseVM>();
                foreach (Course item in courses)
                {
                        courseVMs.Add(new CourseVM
                        {
                            Id = item.Id,
                            CourseName = item.CourseName,
                            Image = item.Image,
                            CourseContent = item.CourseContent
                        });
                }
                if (page == null)
                {
                    ViewBag.Page = 1;
                    return View(courseVMs.OrderByDescending(p => p.Id).Take(8));
                }
                else
                {
                    ViewBag.Page = page;
                    return View(courseVMs.OrderByDescending(p => p.Id).Skip(((int)page - 1) * 8).Take(8));
                }
            }
            
        }
        public async Task<IActionResult> CourseDetails(int? id)
        {
            
            return View(await _db.Courses.FindAsync(id));
        }
        public async Task<IActionResult> Form(Form form)
        {
            if (!ModelState.IsValid) return View();
            await _db.Forms.AddAsync(form);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        
    }
}
