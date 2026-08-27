using lesson3.Models;
using Microsoft.AspNetCore.Mvc;

namespace lesson3.Controllers
{
    [Route("Catalog")]
    public class CatalogController : Controller
    {
        private List<CategoryProduct> electronics = new List<CategoryProduct>
        {
            new CategoryProduct { Name = "Ноутбук", Price = 20000, Quantity = 5},
            new CategoryProduct { Name = "Смартфон", Price = 15000, Quantity = 10},
            new CategoryProduct { Name = "Навушники", Price = 2500, Quantity = 15},
            new CategoryProduct { Name = "Монітор", Price = 8000, Quantity = 7}
        };

        private List<CategoryProduct> clothes = new List<CategoryProduct>
        {
            new CategoryProduct { Name = "Футболка", Price = 500, Quantity = 20},
            new CategoryProduct { Name = "Джинси", Price = 1500, Quantity = 12},
            new CategoryProduct { Name = "Куртка", Price = 3000, Quantity = 8},
            new CategoryProduct { Name = "Кросівки", Price = 2500, Quantity = 10}
        };

        private List<CategoryProduct> food = new List<CategoryProduct>
        {
            new CategoryProduct { Name = "Хліб", Price = 40, Quantity = 30},
            new CategoryProduct { Name = "Молоко", Price = 50, Quantity = 25},
            new CategoryProduct { Name = "Сир", Price = 200, Quantity = 10},
            new CategoryProduct { Name = "Шоколад", Price = 100, Quantity = 18}
        };
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("{category}/Filter")]
        public IActionResult Filter(string category, decimal minPrice, decimal maxPrice)
        {
            List<CategoryProduct> products;
            switch (category)
            {
                case "electronics":
                    products = electronics;
                    break;
                case "clothes":
                    products = clothes;
                    break;
                case "food":
                    products = food;
                    break;
                default:
                    products = new List<CategoryProduct>();
                    break;
            }
            var filteredProducts = products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
            return View(filteredProducts);
        }
    }
}
