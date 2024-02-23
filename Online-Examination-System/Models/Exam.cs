using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Examination_System.Models
{
    public class Exam
    {
        [Key]
        public int Ex_Id { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public int Duration { get; set; }

        public int TotalGrade { get; set; }

        public virtual List<StudentExamQuestion> Exam_Ques_St { get; set; } = new List<StudentExamQuestion>();

        public virtual List<StudentCourseExam> StudentCourseExam { get; set; } = new List<StudentCourseExam>();



    }
}
