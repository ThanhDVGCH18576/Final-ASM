using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Final_ASM.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //skip automatic ID
        [Display(Name = "Number")]
        public int CourseID { get; set; }

        [StringLength(30, ErrorMessage = "Title must be from 3 to 20 characters", MinimumLength = 3)]
        public string Title { get; set; }

        [Range(1, 5, ErrorMessage = "Range must be from 1 to 10")]
        public int Credits { get; set; }

        [ForeignKey("Topic")]
        public int TopicID { get; set; }

        public virtual Topic Topic { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Trainer> Trainers { get; set; }
    }
}