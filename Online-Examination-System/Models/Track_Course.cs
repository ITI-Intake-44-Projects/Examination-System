using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Examination_System.Models
{
    public class Track_Course
    {
        // Composite key: CourseId + TrackId

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        [ForeignKey("Track")]
        public int TrackId { get; set; }

        public virtual Track Track { get; set; }

        public virtual Course Course { get; set; }
    }
}