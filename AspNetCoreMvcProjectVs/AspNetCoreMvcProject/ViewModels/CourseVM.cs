using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.ViewModels
{
    public class CourseVM
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseContent { get; set; }
        public string Image { get; set; }
    }
}
