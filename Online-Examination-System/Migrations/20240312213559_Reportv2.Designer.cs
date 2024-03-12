﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Online_Examination_System.Models;

#nullable disable

namespace Online_Examination_System.Migrations
{
    [DbContext(typeof(OnlineExaminatonSystemContext))]
    [Migration("20240312213559_Reportv2")]
    partial class Reportv2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.1.24081.2")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Online_Examination_System.Models.Branch", b =>
                {
                    b.Property<int>("B_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("B_ID"));

                    b.Property<string>("Location")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("B_ID");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Branch_Track", b =>
                {
                    b.Property<int>("B_Id")
                        .HasColumnType("int");

                    b.Property<int>("Trk_Id")
                        .HasColumnType("int");

                    b.HasKey("B_Id", "Trk_Id");

                    b.HasIndex("Trk_Id");

                    b.ToTable("Branch_Track");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Course", b =>
                {
                    b.Property<int>("Crs_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Crs_ID"));

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Crs_ID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Course_Topics", b =>
                {
                    b.Property<int>("Crs_ID")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<string>("Topic_Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnOrder(1);

                    b.HasKey("Crs_ID", "Topic_Name");

                    b.ToTable("Course_Topics");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Exam", b =>
                {
                    b.Property<int>("Ex_Id")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TotalGrade")
                        .HasColumnType("int");

                    b.HasKey("Ex_Id");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Ins_Branch", b =>
                {
                    b.Property<int>("Ins_Id")
                        .HasColumnType("int");

                    b.Property<int>("B_Id")
                        .HasColumnType("int");

                    b.HasKey("Ins_Id", "B_Id");

                    b.HasIndex("B_Id");

                    b.ToTable("Ins_Branch");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Instructor", b =>
                {
                    b.Property<int>("Ins_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ins_ID"));

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("Working_Hours")
                        .HasColumnType("int");

                    b.HasKey("Ins_ID");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Instructor_Course", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "InstructorId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Instructor_Course");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Instructor_Track", b =>
                {
                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.HasKey("InstructorId", "TrackId");

                    b.HasIndex("TrackId");

                    b.ToTable("Instructor_Track");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Question", b =>
                {
                    b.Property<int>("Q_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Q_Id"));

                    b.Property<int>("Crs_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Marks")
                        .HasColumnType("int");

                    b.Property<string>("ModelAns")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Q_Id");

                    b.HasIndex("Crs_Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Online_Examination_System.Models.QuestionChoice", b =>
                {
                    b.Property<int>("Ques_id")
                        .HasColumnType("int");

                    b.Property<string>("Choice")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Ques_id", "Choice");

                    b.ToTable("Ques_Choices");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Student", b =>
                {
                    b.Property<int>("St_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("St_Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("Date");

                    b.Property<string>("Faculty")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Fname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Lname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mobile")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Passowrd")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("St_Id");

                    b.HasIndex("TrackId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Online_Examination_System.Models.StudentCourseExam", b =>
                {
                    b.Property<int>("St_Id")
                        .HasColumnType("int");

                    b.Property<int>("Crs_Id")
                        .HasColumnType("int");

                    b.Property<int>("Exam_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<int?>("Passed")
                        .HasColumnType("int");

                    b.HasKey("St_Id", "Crs_Id", "Exam_Id");

                    b.HasIndex("Crs_Id");

                    b.HasIndex("Exam_Id");

                    b.ToTable("StudentCourseExam");
                });

            modelBuilder.Entity("Online_Examination_System.Models.StudentExamQuestion", b =>
                {
                    b.Property<int>("Ex_id")
                        .HasColumnType("int");

                    b.Property<int>("Ques_id")
                        .HasColumnType("int");

                    b.Property<int>("St_id")
                        .HasColumnType("int");

                    b.Property<string>("St_Answer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ex_id", "Ques_id", "St_id");

                    b.HasIndex("Ques_id");

                    b.HasIndex("St_id");

                    b.ToTable("Exam_Ques_St");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Track", b =>
                {
                    b.Property<int>("Trk_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Trk_ID"));

                    b.Property<int?>("Capacity")
                        .HasColumnType("int");

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SuperID")
                        .HasColumnType("int");

                    b.HasKey("Trk_ID");

                    b.HasIndex("SuperID");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Track_Course", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "TrackId");

                    b.HasIndex("TrackId");

                    b.ToTable("Track_Course");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Branch_Track", b =>
                {
                    b.HasOne("Online_Examination_System.Models.Branch", "Branch")
                        .WithMany("Branch_Tracks")
                        .HasForeignKey("B_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Examination_System.Models.Track", "Track")
                        .WithMany("Branch_Tracks")
                        .HasForeignKey("Trk_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Course_Topics", b =>
                {
                    b.HasOne("Online_Examination_System.Models.Course", "Course")
                        .WithMany("CourseTopics")
                        .HasForeignKey("Crs_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Ins_Branch", b =>
                {
                    b.HasOne("Online_Examination_System.Models.Branch", "Branch")
                        .WithMany("Ins_Branches")
                        .HasForeignKey("B_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Examination_System.Models.Instructor", "Instructor")
                        .WithMany("Ins_Branches")
                        .HasForeignKey("Ins_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Instructor_Course", b =>
                {
                    b.HasOne("Online_Examination_System.Models.Course", "Course")
                        .WithMany("Instructor_Courses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Examination_System.Models.Instructor", "Instructor")
                        .WithMany("Instructor_Courses")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Instructor_Track", b =>
                {
                    b.HasOne("Online_Examination_System.Models.Instructor", "Instructor")
                        .WithMany("InstructorTracks")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Online_Examination_System.Models.Track", "Track")
                        .WithMany("InstructorTracks")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Question", b =>
                {
                    b.HasOne("Online_Examination_System.Models.Course", "course")
                        .WithMany("questions")
                        .HasForeignKey("Crs_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("course");
                });

            modelBuilder.Entity("Online_Examination_System.Models.QuestionChoice", b =>
                {
                    b.HasOne("Online_Examination_System.Models.Question", "Ques")
                        .WithMany("Choices")
                        .HasForeignKey("Ques_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Ques");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Student", b =>
                {
                    b.HasOne("Online_Examination_System.Models.Track", "Track")
                        .WithMany("Students")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Online_Examination_System.Models.StudentCourseExam", b =>
                {
                    b.HasOne("Online_Examination_System.Models.Course", "Course")
                        .WithMany("StudentCourseExam")
                        .HasForeignKey("Crs_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Examination_System.Models.Exam", "Exam")
                        .WithMany("StudentCourseExam")
                        .HasForeignKey("Exam_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Examination_System.Models.Student", "Student")
                        .WithMany("StudentCourseExam")
                        .HasForeignKey("St_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Exam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Online_Examination_System.Models.StudentExamQuestion", b =>
                {
                    b.HasOne("Online_Examination_System.Models.Exam", "Exam")
                        .WithMany("Exam_Ques_St")
                        .HasForeignKey("Ex_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Examination_System.Models.Question", "Ques")
                        .WithMany("Exam_Ques_St")
                        .HasForeignKey("Ques_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Examination_System.Models.Student", "Student")
                        .WithMany("Exam_Ques_St")
                        .HasForeignKey("St_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Ques");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Track", b =>
                {
                    b.HasOne("Online_Examination_System.Models.Instructor", "TrackSupervisor")
                        .WithMany()
                        .HasForeignKey("SuperID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TrackSupervisor");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Track_Course", b =>
                {
                    b.HasOne("Online_Examination_System.Models.Course", "Course")
                        .WithMany("TrackCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_Examination_System.Models.Track", "Track")
                        .WithMany("TrackCourses")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Branch", b =>
                {
                    b.Navigation("Branch_Tracks");

                    b.Navigation("Ins_Branches");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Course", b =>
                {
                    b.Navigation("CourseTopics");

                    b.Navigation("Instructor_Courses");

                    b.Navigation("StudentCourseExam");

                    b.Navigation("TrackCourses");

                    b.Navigation("questions");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Exam", b =>
                {
                    b.Navigation("Exam_Ques_St");

                    b.Navigation("StudentCourseExam");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Instructor", b =>
                {
                    b.Navigation("Ins_Branches");

                    b.Navigation("InstructorTracks");

                    b.Navigation("Instructor_Courses");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Question", b =>
                {
                    b.Navigation("Choices");

                    b.Navigation("Exam_Ques_St");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Student", b =>
                {
                    b.Navigation("Exam_Ques_St");

                    b.Navigation("StudentCourseExam");
                });

            modelBuilder.Entity("Online_Examination_System.Models.Track", b =>
                {
                    b.Navigation("Branch_Tracks");

                    b.Navigation("InstructorTracks");

                    b.Navigation("Students");

                    b.Navigation("TrackCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
