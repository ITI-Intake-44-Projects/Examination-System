using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Examination_System.Models
{
    public class Track
    {
        [Key]
        public int Trk_ID { get; set; }

        [StringLength(50)]
        public string? Name { get; set; }

        
        [Range(0, 250)]
        public int? Capacity { get; set; }


        [Range(0, 250)]
        public int? Duration { get; set; }

        // Foreign key property
        [ForeignKey("TrackSupervisor")]
        public int SuperID { get; set; }

        // Navigation property for the supervisor
        public virtual Instructor TrackSupervisor { get; set; }

        // Navigation property for the many-to-many relationship
        public virtual List<Track_Course> TrackCourses { get; set; } = new List<Track_Course>();

        public virtual List<Instructor_Track> InstructorTracks { get; set; } = new List<Instructor_Track>();

        // Branch_Track property for the many-to-many relationship
        public virtual List<Branch_Track> Branch_Tracks { get; set; } = new List<Branch_Track>();
    }
}
