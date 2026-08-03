//using EFCore_Sessions_Assignments.Assignment_Session_01.Models;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EFCore_Sessions_Assignments.Assignment_Session_01.Context
//{
//    public class ITIDbContext:DbContext
//    {
//        public ITIDbContext():base() { }
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlServer("Server=DESKTOP-9DG3E18;Database=ITIDdatabase;Trusted_Connection=true;TrustServerCertificate=true");
//        }
//        public DbSet<Students> Students { get; set; }
//        public DbSet<Student_Course> Student_Courses { get; set; }
//        public DbSet<Instructors> Instructors { get; set; }
//        public DbSet<Courses> Courses { get; set; }
//        public DbSet<Course_Instructor> Course_Instructors { get; set; }
//        public DbSet<Topics> Topics { get; set; }
//        public DbSet<Departments> Departments { get; set; } 
//    }
//}
