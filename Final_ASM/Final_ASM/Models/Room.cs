using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Final_ASM.Models
{
    public class Room
    {
        [Key]
        [ForeignKey("Trainer")]
        public int TrainerID { get; set; }

        [StringLength(20)]
        [Display(Name = "Class Room")]
        public string Location { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}