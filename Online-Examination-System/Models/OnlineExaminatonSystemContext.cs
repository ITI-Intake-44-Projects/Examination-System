using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Examination_System.Models
{
    public class OnlineExaminatonSystemContext: DbContext
    {
        public virtual DbSet<Track>? Tracks { get; set; }

        public virtual DbSet<Course>? Courses { get; set; }

        public virtual DbSet<Instructor>? Instructors { get; set; }

        public virtual DbSet<Track_Course>? Track_Course { get; set; }

        public virtual DbSet<Course_Topics>? Course_Topics { get; set; }

        public virtual DbSet<Instructor_Track>? Instructor_Track { get; set; }

        public virtual DbSet<Instructor_Course>? Instructor_Course { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=.;Database=OnlineExaminationSystemDB;Trusted_Connection=True;TrustServerCertificate=True";
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Track_Course Configuration

            // Sets a composite primary key for the Track_Course
            modelBuilder.Entity<Track_Course>().HasKey(tc => new { tc.CourseId, tc.TrackId });

            // track:trackCourse => 1:M, foreign key TrackId
            modelBuilder.Entity<Track_Course>()
                .HasOne(tc => tc.Track)
                .WithMany(t => t.TrackCourses)
                .HasForeignKey(tc => tc.TrackId);

            // course:trackCourse => 1:M, foreign key CourseId
            modelBuilder.Entity<Track_Course>()
                .HasOne(tc => tc.Course)
                .WithMany(c => c.TrackCourses)
                .HasForeignKey(tc => tc.CourseId);


            // Instructor_Track Configuration

            // Sets a composite primary key for the Instructor_Track
            modelBuilder.Entity<Instructor_Track>().HasKey(it => new { it.InstructorId, it.TrackId });

            modelBuilder.Entity<Instructor_Track>()
                .HasOne(it => it.Instructor)
                .WithMany(i => i.InstructorTracks)
                .HasForeignKey(it => it.InstructorId)
                .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<Instructor_Track>()
                .HasOne(it => it.Track)
                .WithMany(t => t.InstructorTracks)
                .HasForeignKey(it => it.TrackId);

            // Instructor_Course Configuration
            modelBuilder.Entity<Instructor_Course>()
                .HasKey(ic => new { ic.CourseId, ic.InstructorId });

            modelBuilder.Entity<Instructor_Course>()
                .HasOne(ic => ic.Instructor)
                .WithMany(i => i.Instructor_Courses)
                .HasForeignKey(ic => ic.InstructorId)
                .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<Instructor_Course>()
                .HasOne(ic => ic.Course)
                .WithMany(c => c.Instructor_Courses)
                .HasForeignKey(ic => ic.CourseId);

            // Course_Topics Configuration
            modelBuilder.Entity<Course_Topics>()
                .HasKey(ct => new { ct.Crs_ID, ct.Topic_Name });

            modelBuilder.Entity<Course_Topics>()
                .HasOne(ct => ct.Course)
                .WithMany(c => c.CourseTopics)
                .HasForeignKey(ct => ct.Crs_ID);

            // Add other configurations if needed...

            base.OnModelCreating(modelBuilder);
        }

    }
}
