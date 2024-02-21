using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Examination_System.Models
{
    public class Instructor
    {
        [Key]
        public int Ins_ID { get; set; }

        [StringLength(50)]
        public string? FName { get; set;}

        [StringLength(50)]
        public string? LName { get; set;}

        [StringLength(50)]
        public string? Address { get; set;}

        [Range(0, 100)]
        public int? Working_Hours { get; set;}

        public DateTime? Birthdate { get; set; }

        // Navigation property for the many-to-many relationship
        public virtual ICollection<Instructor_Track> InstructorTracks { get; set; } = new List<Instructor_Track>();

        public virtual ICollection<Instructor_Course> Instructor_Courses { get; set; } = new List<Instructor_Course>();
    }
}
