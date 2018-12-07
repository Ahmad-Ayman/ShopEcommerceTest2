using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SectionEcommerce5.Data
{
    public class ProjectContext : DbContext
    {
        // Configuration Constructor 
        public ProjectContext(DbContextOptions<ProjectContext> options)
         : base(options)
        {
        }

        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.Course> Courses { get; set; }
        public DbSet<Models.Category> Categories { get; set; }
        public DbSet<Models.Enrollment> Enrollments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Enrollment>()
                .HasKey(en => new { en.UserId, en.CourseId });


            modelBuilder.Entity<Models.Enrollment>()
                .HasOne(en => en._User)
                .WithMany(b => b.CourseList)
                .HasForeignKey(en => en.UserId);


            modelBuilder.Entity<Models.Enrollment>()
                .HasOne(co => co._Course)
                .WithMany(c => c.UserList)
                .HasForeignKey(en => en.CourseId);
        }

    }
}
