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
    public class HomeController : Controller
    {
        private readonly Database _db;
        public HomeController(Database db)
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
            List<Event> events = _db.Events.ToList();

            List<EventVM> eventVMs = new List<EventVM>();
            foreach (Event item in events)
            {
                eventVMs.Add(new EventVM
                {
                    Id = item.Id,
                    EventName = item.EventName,
                    StartTime = item.StartTime,
                    EndTime = item.EndTime,
                    Venue = item.Venue,
                    Image = item.Image,
                    StartDateDayMonth = item.StartDateDayMonth,
                    EventSpeakers = item.EventSpeakers
                });
            }
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
            return View(new HomeVM 
            {
                HomeSliders=_db.HomeSliders,
                Notices=_db.Notices,
                ShortInfos=_db.ShortInfos,
                CourseVMs= courseVMs.Take(3),
                EventVMs= eventVMs.Take(8),
                Testimonials=_db.Testimonials,
                BlogVMs=blogVMs.Take(3)
            });
        }
    }
}
