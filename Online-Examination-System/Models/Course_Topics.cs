using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Examination_System.Models
{
    public class Course_Topics
    {
        // Composite key: Crs_ID + Topic_Name

        [Key, Column(Order = 0)]
        public int Crs_ID { get; set; }

        [Key, Column(Order = 1), StringLength(100)] 
        public string Topic_Name { get; set; }

        // Foreign key relationship
        [ForeignKey("Crs_ID")]
        public virtual Course Course { get; set; }
    }
}
