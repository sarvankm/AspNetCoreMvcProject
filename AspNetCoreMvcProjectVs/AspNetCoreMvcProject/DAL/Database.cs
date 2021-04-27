using AspNetCoreMvcProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcProject.DAL
{
    public class Database:DbContext
    {
        public Database(DbContextOptions<Database> options) : base(options){ }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<EventSpeaker> EventSpeakers { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<CommentForm> CommentForms { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<AboutCourse> AboutCourses { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<HomeSlider> HomeSliders { get; set; }
        public DbSet<ShortInfo> ShortInfos { get; set; }


    }
}
