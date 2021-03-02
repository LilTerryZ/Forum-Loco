using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Forum_Loco.Models
{
    public class User
    {

        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "user name is required")]
        public String UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public String Password { get; set; }

        [Compare("Password",ErrorMessage ="Please Confirm your password")]
        [DataType(DataType.Password)]

        public String ConfirmPassword { get; set; }

    }
}