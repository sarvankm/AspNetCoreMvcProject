using AspNetCoreMvcProject.DAL;
using AspNetCoreMvcProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Controllers
{
    
    public class ContactController : Controller
    {
        private readonly Database _db;
        public ContactController(Database db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
           
            return View(_db.Contacts.Where(c=>c.IsDeleted == false));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Form(Form form)
        {
            if (!ModelState.IsValid) return View();
            await _db.Forms.AddAsync(form);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
