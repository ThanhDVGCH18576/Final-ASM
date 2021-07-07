using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Final_ASM.Models
{
    public enum Grade
    {
        Rerfer, Pass, Merit, Distintion
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int TrainerID { get; set; }
        public int TraineeID { get; set; }


        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Trainer Trainer { get; set; }
        public virtual Trainee Trainee { get; set; }
    }
}