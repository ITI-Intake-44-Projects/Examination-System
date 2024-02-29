using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Examination_System.Models
{
    public class Course
    {
        [Key]
        public int Crs_ID { get; set; }

        [StringLength(50)]
        public string? Name { get; set; }

        [Range(0, 250)]
        public int? Duration { get; set; }

        [Range(0, 250)]
        public int? Grade { get; set; }

        // Navigation properties
        public virtual ICollection<Question> questions { get; set; } = new List<Question>();

        public virtual ICollection<Track_Course> TrackCourses { get; set; } = new List<Track_Course>();

        public virtual ICollection<Instructor_Course> Instructor_Courses { get; set; } = new List<Instructor_Course>();

        public virtual ICollection<Course_Topics> CourseTopics { get; set; } = new List<Course_Topics>();

        public virtual List<StudentCourseExam> StudentCourseExam { get; set; } = new List<StudentCourseExam>();
    }
}
