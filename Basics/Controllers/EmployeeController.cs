using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            string message =  $"Hello World. {DateTime.Now.ToString()}";
            return View("Index1", message);
        }

        public ViewResult Index2()
        {
            var  names = new String[]
            {
                "Ali",
                "Ahmet",
                "Mehmet"
            };
            return View(names);
        }

        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {
                new Employee(){Id=1,FirstName="Ali",LastName="Can",Age=20},
                new Employee(){Id=2,FirstName="Ali",LastName="Ahmet",Age=25},
                new Employee(){Id=3,FirstName="Ali",LastName="Ali",Age=26}
            };
            return View("Index3",list);
        }
    }
}