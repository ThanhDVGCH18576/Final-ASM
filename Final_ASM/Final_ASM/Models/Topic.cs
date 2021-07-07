using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Final_ASM.Models
{
    public class Topic
    {
        public int TopicID { get; set; }

        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Budget { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        public int? TrainerID { get; set; }  // ?: Nullable

        public virtual Trainer Administrator { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}