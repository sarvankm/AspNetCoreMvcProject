using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Areas.Admin.Controllers
{
    public class HomeSliderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
