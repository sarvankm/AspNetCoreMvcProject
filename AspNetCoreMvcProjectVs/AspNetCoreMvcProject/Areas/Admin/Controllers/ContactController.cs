using AspNetCoreMvcProject.DAL;
using AspNetCoreMvcProject.Models;
using FrontToBack.Extensions;
using FrontToBack.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly Database _db;
        public ContactController(Database db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.Contacts);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Contact contact)
        {
            if (ModelState["File"].ValidationState == ModelValidationState.Invalid)
            {
                ModelState.AddModelError("", "Please choose image !");
                return View();
            }

            if (!contact.File.IsImage())
            {
                ModelState.AddModelError("File", $"In this {contact.File.FileName} name file format not correct !");
                return View();
            }

            if (contact.File.CheckFileSize(2000))
            {
                ModelState.AddModelError("File", $" In this {contact.File.FileName} name file size is greater than 150 kb !");
                return View();
            }
            string folder = Path.Combine("img", "contact");

            contact.Image = await contact.File.SaveFileAsync(_env.WebRootPath, folder);

            await _db.Contacts.AddAsync(contact);

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            Contact contact = await _db.Contacts.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (contact == null) return NotFound();
            return View(contact);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Contact contact = await _db.Contacts.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (contact == null) return NotFound();
            return View(contact);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Contact contact)
        {
            if (id == null) return NotFound();
            Contact dbContact = await _db.Contacts.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (dbContact == null) return NotFound();

            if (ModelState["File"].ValidationState == ModelValidationState.Invalid)
            {
                ModelState.AddModelError("", "Please choose image !");
                return View();
            }

            if (!contact.File.IsImage())
            {
                ModelState.AddModelError("File", $"In this {contact.File.FileName} name file format not correct !");
                return View();
            }

            if (contact.File.CheckFileSize(2000))
            {
                ModelState.AddModelError("File", $" In this {contact.File.FileName} name file size is greater than 150 kb !");
                return View();
            }

            string folder = Path.Combine("img", "contact");

            Helper.DeleteFile(_env.WebRootPath, folder, dbContact.Image);

            dbContact.Street = contact.Street;
            dbContact.CountryCity = contact.CountryCity;
            dbContact.Image = await contact.File.SaveFileAsync(_env.WebRootPath, folder);

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Contact contact = await _db.Contacts.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (contact == null) return NotFound();
            return View(contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteContact(int? id)
        {
            if (id == null) return NotFound();
            Contact dbContact = await _db.Contacts.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);
            if (dbContact == null) return NotFound();
            string folder = Path.Combine("img", "contact");

            Helper.DeleteFile(_env.WebRootPath, folder, dbContact.Image);

            dbContact.IsDeleted = true;
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
