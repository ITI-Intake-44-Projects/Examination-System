using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Examination_System.Models
{
    public class Instructor_Course
    {
        // Composite key: CourseId + InstructorId
        [Key, Column(Order = 0)]
        public int CourseId { get; set; }

        [Key, Column(Order = 1)]
        public int InstructorId { get; set; }

        // Navigation properties
        public virtual Instructor Instructor { get; set; }
        public virtual Course Course { get; set; }
    }
}
