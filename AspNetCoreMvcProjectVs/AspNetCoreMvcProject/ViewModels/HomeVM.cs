using AspNetCoreMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<HomeSlider> HomeSliders { get; set; }
        public IEnumerable<Notice> Notices { get; set; }
        public IEnumerable<ShortInfo> ShortInfos { get; set; }
        public IEnumerable<CourseVM> CourseVMs { get; set; }
        public IEnumerable<EventVM> EventVMs { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
        public IEnumerable<BlogVM> BlogVMs { get; set; }


    }
}
