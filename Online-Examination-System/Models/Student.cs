using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Examination_System.Models
{
    public class Student
    {
        [Key]
        public int St_Id { get; set; }

        [StringLength(50)]
        public string? Fname { get; set; }

        [StringLength(50)]
        public string? Lname { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? BirthDate { get; set; }

        [StringLength(50)]
        public string? Address { get; set; }

        [StringLength(50)]

        public string? Mobile { get; set; }

        [StringLength(50)]
        public string? Faculty { get; set; }

        [StringLength(20)]
        public string? Gender { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(20)]
        public string Passowrd { get; set; }

        [ForeignKey("Track")]
        public int TrackId {  get; set; }

        public virtual Track Track { get; set; }


        public virtual List<StudentExamQuestion> Exam_Ques_St { get; set; } = new List<StudentExamQuestion>();

        public virtual List<StudentCourseExam> StudentCourseExam { get; set; } = new List<StudentCourseExam>();




    }
}
