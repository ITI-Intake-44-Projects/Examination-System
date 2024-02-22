using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Online_Examination_System.Models
{
    public class Ins_Branch
    {
        [ForeignKey("Instructor")]
        public int Ins_Id { get; set; }
        [ForeignKey("Branch")]
        public int B_Id { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}
