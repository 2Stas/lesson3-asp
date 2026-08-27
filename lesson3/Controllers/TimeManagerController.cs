using Microsoft.AspNetCore.Mvc;

namespace lesson3.Controllers
{
    public class TimeManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Me()
        {
            return Content("Free Time: 10 hours");
        }
        public IActionResult AboutMe()
        {
            return Content("About Me \nMy name: John Doe \nMy age: 30 \nMy hobbies: Reading, Swimming");
        }
        public IActionResult ContactMe()
        {
            return Content("Contact Me \nEmail: john.doe@example.com \nPhone: 123-456-7890");
        }
        public IActionResult ViewName()
        {
            return Content("My name is John Doe");
        }
        public IActionResult ViewLastName()
        {
            return Content("My last name is Doe");
        }
        public IActionResult ManageTime(string task, int hours)
        {
            if(hours <= 0 || task == null || task == "")
            {
                return Content("Error: Invalid input");
            }
            return Content($"Task: {task} \nHours for it: {hours}");
        }
    }
}
