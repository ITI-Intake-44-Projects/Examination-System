using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Examination_System.Models
{
    public class Instructor_Track
    {

        // Foreign keys

        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }

        [ForeignKey("Track")]
        public int TrackId { get; set; }

        // Navigation properties
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public virtual Instructor Instructor { get; set; }

        //[DeleteBehavior(DeleteBehavior.NoAction)]
        public virtual Track Track { get; set; }
    }
}
