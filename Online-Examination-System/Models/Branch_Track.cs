using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Examination_System.Models
{
    public class Branch_Track
    {
        [ForeignKey("Branch")]
        public int B_Id { get; set; }
        [ForeignKey("Track")]
        public int Trk_Id { get; set; }
 
        public virtual Branch Branch { get; set; }
        public virtual Track Track { get; set; }
    }
}
