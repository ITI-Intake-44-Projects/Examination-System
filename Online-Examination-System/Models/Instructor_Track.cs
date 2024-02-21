using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Examination_System.Models
{
    public class Instructor_Track
    {

        // Foreign keys
        public int InstructorId { get; set; }
        public int TrackId { get; set; }

        // Navigation properties
        public virtual Instructor Instructor { get; set; }
        public virtual Track Track { get; set; }
    }
}
