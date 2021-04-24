using AspNetCoreMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.ViewModels
{
    public class AboutVM
    {
        public IEnumerable<AboutCourse> AboutCourses { get; set; }
        public IEnumerable<TeacherVM> Teachers { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
        public IEnumerable<Notice> Notices { get; set; }

    }
}
