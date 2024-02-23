using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Examination_System.Models
{
    public class StudentExamQuestion
    {
        [ForeignKey("Exam")]

        public int Ex_id { get; set; }

        [ForeignKey("Ques")]

        public int Ques_id { get; set; }

        [ForeignKey("Student")]

        public int St_id { get; set; }


        public string St_Answer { get; set; }

        public virtual Student Student { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual Question Ques { get; set; }
    }
}
