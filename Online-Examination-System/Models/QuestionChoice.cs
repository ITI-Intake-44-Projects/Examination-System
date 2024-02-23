using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Examination_System.Models
{
    public class QuestionChoice
    {
        [ForeignKey("Ques")]

        public int Ques_id { get; set; }

        public string Choice { get; set; }

        [DeleteBehavior(DeleteBehavior.NoAction)]
        public virtual Question Ques { get; set; }
    }
}
