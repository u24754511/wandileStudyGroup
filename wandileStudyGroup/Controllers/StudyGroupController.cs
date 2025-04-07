using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace wandileStudyGroup_Prac4.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult StudyGroupMembers()
        {

            List<Models.StudentClass> students = new List<Models.StudentClass>();
            {
                students.Add(new Models.StudentClass { StudentNumber = "u24754511", FName = "Wandile", LName = "Mngomezulu", Email = "u24754511@tuks.co.za", myLink= "~/HTML/Wandile.html" });
                students.Add(new Models.StudentClass { StudentNumber = "u24436729", FName = "Odaho", LName = "Mudau", Email = "Jrmudau23@gmail.com", myLink = "~/HTML/Odaho.html" });
                students.Add(new Models.StudentClass { StudentNumber = "u21784532", FName = "Mary", LName = "Modiba", Email = "mummymodiba20@gmail.com" , myLink = "~/HTML/Mary.html" });
                students.Add(new Models.StudentClass { StudentNumber = "u24556901", FName = "Sanele", LName = "Khanyile", Email = "KhanyileSanele90@gmail.com" , myLink = "~/HTML/Sanele.html" });
                students.Add(new Models.StudentClass { StudentNumber = "u24594319", FName = "Aphiwe", LName = "Mdletshe", Email = "Aphiwemdletshe267@gmail.com"     , myLink = "~/HTML/Aphiwe.html" });
            }



            return View(students);
        }
    }
}