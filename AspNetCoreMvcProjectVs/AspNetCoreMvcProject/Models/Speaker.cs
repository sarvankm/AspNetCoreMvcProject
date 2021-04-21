using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        [Required,StringLength(255)]
        public string FullName { get; set; }
        [Required, StringLength(255)]
        public string Speciality { get; set; }
        [Required]
        public string Image { get; set; }
        public virtual ICollection<EventSpeaker> EventSpeakers { get; set; }



    }
}
