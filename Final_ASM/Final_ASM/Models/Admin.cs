using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Final_ASM.Models
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Email can't longer than 50 character")]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [StringLength(10)]
        public string Role { get; set; }
    }
}