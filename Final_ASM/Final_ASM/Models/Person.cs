using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Final_ASM.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "First name can not be longer than 50 characters")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        public string FullName
        {
            get
            {
                return LastName + " " + FirstMidName;
            }
        }

        [Required]
        [StringLength(100, ErrorMessage = "Email can not longer than 100 characters")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Addrees can not longer than 50 characters")]
        [Display(Name = "Address")]
        public string Address { get; set; }
    }
}
