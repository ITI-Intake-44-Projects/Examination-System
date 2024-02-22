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

        public virtual DbSet<Branch>? Branches { get; set; }

        public virtual DbSet<Ins_Branch>? Ins_Branch { get; set; }

        public virtual DbSet<Branch_Track>? Branch_Track { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=.;Database=OnlineExaminationSystemDB;Trusted_Connection=True;TrustServerCertificate=True";
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Track_Course>()
                .HasKey(tc => new { tc.CourseId, tc.TrackId });

            modelBuilder.Entity<Instructor_Track>()
                .HasKey(it => new { it.InstructorId, it.TrackId });

            modelBuilder.Entity<Instructor_Course>()
                .HasKey(ic => new { ic.CourseId, ic.InstructorId });

            modelBuilder.Entity<Course_Topics>()
                .HasKey(ct => new { ct.Crs_ID, ct.Topic_Name });

            modelBuilder.Entity<Ins_Branch>()
                .HasKey("Ins_Id", "B_Id");

            modelBuilder.Entity<Branch_Track>()
                .HasKey("B_Id", "Trk_Id");
        }

    }
}
