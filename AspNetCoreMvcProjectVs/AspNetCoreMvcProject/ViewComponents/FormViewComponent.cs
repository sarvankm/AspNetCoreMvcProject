using AspNetCoreMvcProject.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.ViewComponents
{
    public class FormViewComponent : ViewComponent
    {
        private readonly Database _db;
        public FormViewComponent(Database db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _db.Forms.FirstOrDefaultAsync());
        }
    }
}
