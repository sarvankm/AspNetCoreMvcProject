﻿using AspNetCoreMvcProject.Models;
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
        public DbSet<Course> CourseCards { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<EventSpeaker> EventSpeakers { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Skills> Skills { get; set; }


    }
}
