using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace wandileStudyGroup.Models
{
	public class StudentClass
	{
        [Display(Name = "u24754511")]// This is a decorator. This is what should show when the Webpage loads. 
        public string StudentNumber { get; set; }

        [Display(Name = "John")]//A decorator
        public string FName { get; set; }

        [Display(Name = "Doe")]//A decorator
        public string LName { get; set; }

        [Display(Name = "Example1@gmail.com")]//A decorator
        public string Email { get; set; }

    }
}