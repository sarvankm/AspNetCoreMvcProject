using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.Models
{
    public class Notice
    {
        public int Id { get; set; }
        public string VideoLink { get; set; }
        public DateTime NoticeDate { get; set; }
        public string NoticeText { get; set; }
        public bool IsDeleted { get; set; }


    }
}
