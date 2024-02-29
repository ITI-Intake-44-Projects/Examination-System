using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Examination_System.Models
{
    public class Question
    {
        [Key]
        public int Q_Id { get; set; }

        public string? Name { get; set; }

        [StringLength(50)]
        public string? type { get; set; }

        public int? Marks { get; set; }

        [ForeignKey("course")]
        public int Crs_Id { get; set; }

        public virtual Course course { get; set; }


        public string ModelAns { get; set; }


        public virtual List<StudentExamQuestion> Exam_Ques_St { get; set; } = new List<StudentExamQuestion>();

        public virtual List<QuestionChoice> Choices { get; set; } = new List<QuestionChoice>();

    }
}
