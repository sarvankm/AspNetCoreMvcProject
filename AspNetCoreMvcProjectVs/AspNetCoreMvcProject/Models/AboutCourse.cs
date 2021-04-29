using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Models
{
    public class AboutCourse
    {
        public int Id { get; set; }
        [Required]
        public string Heading { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        [NotMapped,Required]
        public IFormFile File { get; set; }
        public bool IsDeleted { get; set; }

    }
}
