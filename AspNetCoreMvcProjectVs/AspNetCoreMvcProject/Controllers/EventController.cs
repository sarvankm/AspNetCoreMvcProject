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
    public class EventController : Controller
    {
        private readonly Database _db;
        public EventController(Database db)
        {
            _db = db;
        }
        public IActionResult Index(string search, int? page)
        {
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Events.Count() / 8);

            if (search != null)
            {
                List<Event> events = _db.Events.Where(e => e.IsDeleted == false).ToList();

                List<EventVM> eventVMs = new List<EventVM>();

                foreach (Event item in events)
                {
                    eventVMs.Add(new EventVM
                    {
                        Id = item.Id,
                        EventName = item.EventName,
                        StartTime = item.StartTime,
                        EndTime = item.EndTime,
                        Venue = item.Venue,
                        Image = item.Image,
                        StartDateDayMonth = item.StartDateDayMonth,
                        EventSpeakers = item.EventSpeakers
                    });
                }

                if (page == null)
                {
                    ViewBag.Page = 1;
                    IEnumerable<EventVM> model = eventVMs
                    .Where(c => c.EventName.ToLower().Contains(search.ToLower()))
                    .OrderByDescending(c => c.Id).Take(8);
                    return View(model);

                }
                else
                {
                    ViewBag.Page = page;
                    IEnumerable<EventVM> model = eventVMs
                    .Where(c => c.EventName.ToLower().Contains(search.ToLower()))
                    .OrderByDescending(c => c.Id).Skip(((int)page - 1) * 8).Take(8);
                    return View(model);
                }
            }
            else
            {
                List<Event> events = _db.Events.Where(e => e.IsDeleted == false).ToList();

                List<EventVM> eventVMs = new List<EventVM>();

                foreach (Event item in events)
                {
                    eventVMs.Add(new EventVM
                    {
                        Id = item.Id,
                        EventName = item.EventName,
                        StartTime = item.StartTime,
                        EndTime = item.EndTime,
                        Venue = item.Venue,
                        Image = item.Image,
                        StartDateDayMonth = item.StartDateDayMonth,
                        EventSpeakers = item.EventSpeakers
                    });
                }
                if (page == null)
                {
                    ViewBag.Page = 1;
                    return View(eventVMs.OrderByDescending(p => p.Id).Take(8));
                }
                else
                {
                    ViewBag.Page = page;
                    return View(eventVMs.OrderByDescending(p => p.Id).Skip(((int)page - 1) * 8).Take(8));
                }
            }
        }
        public async Task<IActionResult> EventDetails(int? id)
        {
            return View(await _db.Events.Include(e=>e.EventSpeakers).ThenInclude(es=>es.Speaker).FirstOrDefaultAsync(e=>e.Id==id));
        }
        public async Task<IActionResult> Form(Form form)
        {
            if (!ModelState.IsValid) return View();
            await _db.Forms.AddAsync(form);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
