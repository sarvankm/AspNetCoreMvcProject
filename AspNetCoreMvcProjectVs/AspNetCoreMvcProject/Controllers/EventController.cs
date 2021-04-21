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
        public IActionResult Index()
        {
            List<Event> events = _db.Events.ToList();

            List<EventVM> eventVMs = new List<EventVM>();
            foreach (Event item in events)
            {
                eventVMs.Add(new EventVM
                {
                    Id=item.Id,
                    EventName=item.EventName,
                    StartTime=item.StartTime,
                    EndTime=item.EndTime,
                    Venue=item.Venue,
                    Image=item.Image,
                    StartDateDayMonth=item.StartDateDayMonth,
                    EventSpeakers=item.EventSpeakers
                });
            }

            return View(eventVMs);
        }
        public async Task<IActionResult> EventDetails(int? id)
        {
            return View(await _db.Events.Include(e=>e.EventSpeakers).ThenInclude(es=>es.Speaker).FirstOrDefaultAsync(e=>e.Id==id));
        }
    }
}
