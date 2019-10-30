using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JSONTestApplication.Models;
using Newtonsoft.Json;

namespace JSONTestApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult EmployeeDetails()
        {
            // Create List
            List<Employee> Employees = new List<Employee>()
            {
                new Employee {Id = 1, Name = "Greg", Address = "123 Road Rd", City = "Jacksonville"},
                new Employee {Id = 2, Name = "Bill", Address = "321 Drive Dr", City = "Orange Park"},
                new Employee {Id = 3, Name = "James", Address="456 Lane Ln", City = "Fleming Island"}
            };

            // Return list as JSON
            return Json(Employees);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
