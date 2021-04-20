using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Models
{
    public class CourseCard
    {
        public int Id { get; set; }
        [Required,StringLength(255)]
        public string CourseName { get; set; }
        [Required,StringLength(4000)]
        public string CourseContent { get; set; }
        [Required,StringLength(1000)]
        public string Image { get; set; }
      
    }
}
