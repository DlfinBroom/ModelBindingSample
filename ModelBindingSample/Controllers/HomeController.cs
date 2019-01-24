using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBindingSample.Models;

namespace ModelBindingSample.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult About() {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact() {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [HttpGet] // Default
        public IActionResult StudentForm() {
            return View();
        }

        [HttpPost] // Used when Submited/Posted to the server
        public IActionResult StudentForm(IFormCollection data) {
            string FirstName = data["FirstName"];
            string LastName = data["LastName"];

            // ToDo: Add Validation

            Student stu = new Student();
            stu.FirstName = FirstName;
            stu.LastName = LastName;

            // ToDo: Add Student to Db

            // ViewData is automatically visable in the view
            ViewData["Msg"] = "Thanks for adding " + FirstName + " " + LastName;

            return View();
        }

        [HttpGet] // Default
        public IActionResult StudentBinding() {
            return View();
        }
        [HttpPost]
        public IActionResult StudentBinding(Student stu) {
            // Validate input
            if (ModelState.IsValid) {
                // Add to database

                return RedirectToAction("Index");
            }
            return View(stu);
            
        }

        public IActionResult StudentAcaffold() {
            return View();
        }
    }
}