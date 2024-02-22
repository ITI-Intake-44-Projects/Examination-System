using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Online_Examination_System.Models
{
    public class Branch
    {
        [Key]
        public int B_ID { get; set; }

        [StringLength(50)]
        public string? Name { get; set; }

        [StringLength(50)]
        public string? Location { get; set; }

        public virtual List<Ins_Branch> Ins_Branches { get; set; } = new List<Ins_Branch>();
        public virtual List<Branch_Track> Branch_Tracks { get; set; } = new List<Branch_Track>();
    }
}
