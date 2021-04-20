using AspNetCoreMvcProject.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Controllers
{
    public class CourseDetailController : Controller
    {
        private readonly Database _db;
        public CourseDetailController(Database db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }

}
