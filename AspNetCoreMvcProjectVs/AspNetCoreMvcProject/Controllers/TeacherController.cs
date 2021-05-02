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
        public IActionResult Index(string search,int? page)
        {
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Teachers.Count() / 8);

            if (search != null)
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
             
                if (page == null)
                {
                    ViewBag.Page = 1;
                    IEnumerable<TeacherVM> model = teacherVMs
                    .Where(t => t.FullName.ToLower().Contains(search.ToLower()))
                    .OrderByDescending(c => c.Id).Take(8);
                    return View(model);

                }
                else
                {
                    ViewBag.Page = page;
                    IEnumerable<TeacherVM> model = teacherVMs
                    .Where(t => t.FullName.ToLower().Contains(search.ToLower()))
                    .OrderByDescending(c => c.Id).Skip(((int)page - 1) * 8).Take(8);
                    return View(model);
                }
            }
            else
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
                if (page == null)
                {
                    ViewBag.Page = 1;
                    return View(teacherVMs.OrderByDescending(p => p.Id).Take(8));
                }
                else
                {
                    ViewBag.Page = page;
                    return View(teacherVMs.OrderByDescending(p => p.Id).Skip(((int)page - 1) * 8).Take(8));
                }
            }
        }
        public async Task<IActionResult> TeacherDetails(int? id)
        {

            return View(await _db.Teachers.Include(t=>t.Skills).FirstOrDefaultAsync(t=>t.Id == id));
        }
    }
}
