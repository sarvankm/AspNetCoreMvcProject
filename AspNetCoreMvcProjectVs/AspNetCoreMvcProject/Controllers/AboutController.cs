using AspNetCoreMvcProject.DAL;
using AspNetCoreMvcProject.Models;
using AspNetCoreMvcProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly Database _db;
        public AboutController(Database db)
        {
            _db = db;
        }
        public  IActionResult Index()
        {
            List<Teacher> teachers = _db.Teachers.Where(t => t.IsDeleted == false).ToList();

            List<TeacherVM> teacherVMs = new List<TeacherVM>();
            foreach (Teacher item in teachers)
            {
                teacherVMs.Add(new TeacherVM
                {
                    Id = item.Id,
                    Image = item.Image,
                    FullName = item.FullName,
                    Profession = item.Profession,
                    OwnFacebook = item.OwnFacebook,
                    OwnPinterest = item.OwnPinterest,
                    OwnTwitter = item.OwnTwitter,
                    OwnVimeo = item.OwnVimeo
                });
            }
            return View( new AboutVM { 
                AboutCourses=  _db.AboutCourses,
                Teachers=teacherVMs,
                Testimonials=_db.Testimonials,
                Notices=_db.Notices
            });
        }
    }
}
