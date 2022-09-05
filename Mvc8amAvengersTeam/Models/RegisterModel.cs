using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc8amAvengersTeam.Models
{
    public class RegisterModel
    {
        public string UserName { get; set; }//textbox
        public string Password { get; set; }//pwd
        public string Gender { get; set; }//Radio

        public string EmployeeName { get; set; }//DropdownList

        public bool Agreement { get; set; }//Checkbox
    }
}