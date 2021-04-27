using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Models
{
    public class Course
    {

        public int Id { get; set; }
        [Required,StringLength(255)]
        public string CourseName { get; set; }
        [Required]
        public string CourseContent { get; set; }
        [Required,StringLength(1000)]
        public string Image { get; set; }
        
        [Required]
        public string AboutCourse { get; set; }
        [Required]
        public string HowToApply { get; set; }
        [Required]
        public string Certification { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        public int ClassDuration { get; set; }
        [Required]
        public string SkillLevel { get; set; }
        [Required]
        public string Language { get; set; }
        [Required]
        public int StudentsCount { get; set; }
        [Required]
        public string Assesments { get; set; }
        [Required]
        public int Price { get; set; }

        public bool IsDeleted { get; set; }
        [NotMapped, Required]
        public IFormFile File { get; set; }

    }
}
