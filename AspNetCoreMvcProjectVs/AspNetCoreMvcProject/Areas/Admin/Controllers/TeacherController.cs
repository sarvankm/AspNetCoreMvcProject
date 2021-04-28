using AspNetCoreMvcProject.DAL;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Areas.Admin.Controllers
{
    public class TeacherController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly Database _db;
        public TeacherController(Database db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
