using AspNetCoreMvcProject.DAL;
using AspNetCoreMvcProject.Models;
using AspNetCoreMvcProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            List<Course> courses = _db.CourseCards.ToList();

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

            return View(courseVMs);
        }
        public async Task<IActionResult> CourseDetails(int? id)
        {
            
            return View(await _db.CourseCards.FindAsync(id));
        }
    }
}
