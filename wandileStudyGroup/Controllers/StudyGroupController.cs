using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace wandileStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult StudyGroupMembers()
        {

            List<Models.StudentClass> students = new List<Models.StudentClass>();
            {
                students.Add(new Models.StudentClass { StudentNumber = "u24754511", FName = "Wandile", LName = "Mngomezulu", Email = "u24754511@tuks.co.za" });
                students.Add(new Models.StudentClass { StudentNumber = "u24436729", FName = "Odaho", LName = "Mudau", Email = "Jrmudau23@gmail.com" });
                students.Add(new Models.StudentClass { StudentNumber = "u21784532", FName = "Mary", LName = "Modiba", Email = "mummymodiba20@gmail.com" });
                students.Add(new Models.StudentClass { StudentNumber = "u24556901", FName = "Sanele", LName = "Khanyile", Email = "KhanyileSanele90@gmail.com" });
                students.Add(new Models.StudentClass { StudentNumber = "u24594319", FName = "Aphiwe", LName = "Mdletshe", Email = "Aphiwemdletshe267@gmail.com" });
            }



            return View(students);
        }
    }
}