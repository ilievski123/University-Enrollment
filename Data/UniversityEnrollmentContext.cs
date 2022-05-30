#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using UniversityEnrollment.Areas.Identity.Data;
using UniversityEnrollment.Models;
using Microsoft.AspNetCore.Identity;

namespace UniversityEnrollment.Models
{
    public class UniversityEnrollmentContext : IdentityDbContext<UniversityEnrollmentUser>
    {
        public UniversityEnrollmentContext(DbContextOptions<UniversityEnrollmentContext> options)
            : base(options)
        {
        }

        public DbSet<UniversityEnrollment.Models.Course> Course { get; set; }

        public DbSet<UniversityEnrollment.Models.Student> Student { get; set; }

        public DbSet<UniversityEnrollment.Models.Teacher> Teacher { get; set; }

        public DbSet<UniversityEnrollment.Models.Enrollment> Enrollment { get; set; }

       
        protected override void OnModelCreating(ModelBuilder builder)
         {
            base.OnModelCreating(builder);

            builder.Entity<Enrollment>()
             .HasOne<Student>(p => p.student)
             .WithMany(p => p.Courses)
             .HasForeignKey(p => p.studentId);
             //.HasPrincipalKey(p => p.Id);
             builder.Entity<Enrollment>()
             .HasOne<Course>(p => p.course)
             .WithMany(p => p.Students)
             .HasForeignKey(p => p.courseId);
             //.HasPrincipalKey(p => p.Id);
             builder.Entity<Course>()
             .HasOne<Teacher>(p => p.firstTeacher)
             .WithMany(p => p.Courses1)
             .HasForeignKey(p => p.firstTeacherId);
             //.HasPrincipalKey(p => p.Id);
             builder.Entity<Course>()
            .HasOne<Teacher>(p => p.secondTeacher)
            .WithMany(p => p.Courses2)
            .HasForeignKey(p => p.secondTeacherId);
            //.HasPrincipalKey(p => p.Id); 
            


        } 
     } 
    
}