using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Final_ASM.Models
{
    public class Trainee:Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Assign Date")]
        public DateTime EnrollmentDate { get; set; }

        //Navigation Properties
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}