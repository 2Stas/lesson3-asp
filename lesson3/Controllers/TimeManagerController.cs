using Microsoft.AspNetCore.Mvc;

namespace lesson3.Controllers
{
    [Route("TimeManager")]
    public class TimeManagerController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return Content("Welcome to the Time Manager!");
        }
        [HttpGet("Me")]
        public IActionResult Me()
        {
            return Content("Free Time: 10 hours");
        }
        [HttpGet("AboutMe")]
        public IActionResult AboutMe()
        {
            return Content("About Me \nMy name: John Doe \nMy age: 30 \nMy hobbies: Reading, Swimming");
        }
        [HttpGet("ContactMe")]
        public IActionResult ContactMe()
        {
            return Content("Contact Me \nEmail: john.doe@example.com \nPhone: 123-456-7890");
        }
        [HttpGet("ViewName")]
        public IActionResult ViewName()
        {
            return Content("My name is John Doe");
        }
        [HttpGet("ViewLastName")]
        public IActionResult ViewLastName()
        {
            return Content("My last name is Doe");
        }
        [HttpPost("ManageTime?{task}&hours={hours}")]
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
