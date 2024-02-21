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

        [Key, Column(Order=0)]
        public int CourseId { get; set; }

        [Key, Column(Order=1)]
        public int TrackId { get; set; }

        public virtual Track Track { get; set; }

        public virtual Course Course { get; set; }

        public virtual ICollection<Track_Course> TrackCourses { get; set; } = new List<Track_Course>();
    }
}