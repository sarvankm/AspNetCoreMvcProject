using AspNetCoreMvcProject.DAL;
using AspNetCoreMvcProject.Models;
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
            
            return View(_db.CourseCards);
        }
    }
}
