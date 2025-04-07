using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace wandileStudyGroup_Prac4.Models
{
    public class StudentClass
    {
        [Display(Name = "Student Number")]// This is a decorator. This is what should show when the Webpage loads. 
        public string StudentNumber { get; set; }

        [Display(Name = "First Name")]//A decorator
        public string FName { get; set; }

        [Display(Name = "Last Name")]//A decorator
        public string LName { get; set; }

        [Display(Name = "Email Address")]//A decorator
        public string Email { get; set; }

        // Add a property to the model called ‘myLink’ of type string.
        [Display(Name = "Link to Personal Page")]
        public string myLink { get; set; }

        [Display(Name = "Delete")]
        public string remover { get; set; }
    }
}