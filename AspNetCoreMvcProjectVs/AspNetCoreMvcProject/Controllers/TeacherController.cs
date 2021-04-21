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
    public class TeacherController : Controller
    {
        private readonly Database _db;
        public TeacherController(Database db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Teacher> teachers = _db.Teachers.ToList();

            List<TeacherVM> teacherVMs = new List<TeacherVM>();
            foreach (Teacher item in teachers)
            {
                teacherVMs.Add(new TeacherVM
                {
                    Id = item.Id,
                    Image=item.Image,
                    FullName=item.FullName,
                    Profession=item.Profession,
                    OwnFacebook=item.OwnFacebook,
                    OwnPinterest=item.OwnPinterest,
                    OwnTwitter=item.OwnTwitter,
                    OwnVimeo=item.OwnVimeo
                });
            }
            return View(teacherVMs);
        }
        public async Task<IActionResult> TeacherDetails(int? id)
        {

            return View(await _db.Teachers.Include(t=>t.Skills).FirstOrDefaultAsync(t=>t.Id == id));
        }
    }
}
