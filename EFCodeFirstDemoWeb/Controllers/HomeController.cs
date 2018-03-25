using System;
using System.Linq;
using System.Web.Mvc;
using EFCodeFirstDemoWeb.Models;

namespace EFCodeFirstDemoWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (var context = new MyContext())
            {
                // Create and save a new Students
                //Console.WriteLine("Adding new students");

                var student = new Student
                {
                    FirstMidName = "Alain",
                    LastName = "Bomer",
                    EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
                };

                context.Students.Add(student);
                context.SaveChanges();

                var student1 = new Student
                {
                    FirstMidName = "Mark",
                    LastName = "Upston",
                    EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
                };

                context.Students.Add(student1);
                context.SaveChanges();

                //Display all Students from the database
                var students = (from s in context.Students
                                orderby s.FirstMidName
                                select s).ToList<Student>();



                ViewBag.Students = students;
            }
            return View();
        }
    }
}