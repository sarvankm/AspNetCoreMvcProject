using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        public string EventName { get; set; }
        [Required]
       
        public DateTime StartTime { get; set; }
        [Required]
       
        public DateTime EndTime { get; set; }
        [Required]
        public string Venue { get; set; }
        [Required]
        public string EventContent { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public DateTime StartDateDay { get; set; }
        [Required]
        public DateTime StartDateMonths { get; set; }
        public virtual ICollection<EventSpeaker> EventSpeakers { get; set; }

    }
}
