using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Models
{
    public class EventSpeaker
    {
        public int Id { get; set; }
        [Required]
        public int SpeakerId { get; set; }
        [Required]
        public Speaker Speaker { get; set; }
        [Required]
        public int EventId { get; set; }
        [Required]
        public Event Event { get; set; }

    }
}
