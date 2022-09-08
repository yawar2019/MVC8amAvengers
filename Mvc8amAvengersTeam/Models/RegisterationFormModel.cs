using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc8amAvengersTeam.Models
{
    public class RegisterationFormModel
    {
        public int UserId { get; set; }
        [Required(ErrorMessage ="UserName Cannot be Empty")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "UserName Cannot be Empty")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Pwd and CPwd Mismatch")]
        public string ConfirPassword { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [Range(3,15,ErrorMessage ="3-15 yrs student can register here")]
        public int age { get; set; }

        [StringLength(10,ErrorMessage ="More then 10 characters not allowed")]
       [RegularExpression(@"\d{2,5}",ErrorMessage ="Only numbers")]
        public string Address { get; set; }

    }
}