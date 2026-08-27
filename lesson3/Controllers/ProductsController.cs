using Microsoft.AspNetCore.Mvc;

namespace lesson3.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return Content("Product Page");
        }
        public IActionResult Details(int id)
        {
            if (id == 0)
            {
                return Content("Invalid product ID");
            }
            else
            {
                return Content("Details Page : " + id);
            }
        }
        public IActionResult About()
        {
            return Content("About Page");
        }
        public IActionResult Search(int id, string nameProduct, int cost)
        {
            return Content($"Search Results - ID: {id}, Name: {nameProduct}, Cost: {cost}");
        }
    }
}
