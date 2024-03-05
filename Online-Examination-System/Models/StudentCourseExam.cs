using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Examination_System.Models
{
    public class StudentCourseExam
    {
        [ForeignKey("Student")]
        public int St_Id { get; set; }

        [ForeignKey("Course")]
        public int Crs_Id { get; set; }

        [ForeignKey("Exam")]
        public int Exam_Id { get; set; }


        public int? Grade { get; set; }

        public int? Passed { get; set; }

        public virtual Student Student { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual Course Course { get; set; }


    }
}
