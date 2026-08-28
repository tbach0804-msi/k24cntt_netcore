using lesson03.Models;
using Microsoft.AspNetCore.Mvc;

namespace lesson03.Controllers
{
    public class ThbProductController : Controller
    {
        private readonly List<ThbProduct> _products = new()
        {
          new ThbProduct
    {
        ThbProductId = "SP001",
        ThbProductName = "iPhone 15",
        ThbYearRelease = "2023",
        ThbPrice = 18990000
    },
    new ThbProduct
    {
        ThbProductId = "SP002",
        ThbProductName = "Samsung Galaxy S24",
        ThbYearRelease = "2024",
        ThbPrice = 21990000
    },
    new ThbProduct
    {
        ThbProductId = "SP003",
        ThbProductName = "Xiaomi 14",
        ThbYearRelease = "2024",
        ThbPrice = 16990000
    },
    new ThbProduct
    {
        ThbProductId = "SP004",
        ThbProductName = "Google Pixel 8",
        ThbYearRelease = "2023",
        ThbPrice = 15990000
    },
    new ThbProduct
    {
        ThbProductId = "SP005",
        ThbProductName = "OPPO Find X7",
        ThbYearRelease = "2024",
        ThbPrice = 17990000
    },
    new ThbProduct
    {
        ThbProductId = "SP006",
        ThbProductName = "MacBook Air M2",
        ThbYearRelease = "2022",
        ThbPrice = 24990000
    },
    new ThbProduct
    {
        ThbProductId = "SP007",
        ThbProductName = "Dell Inspiron 15",
        ThbYearRelease = "2023",
        ThbPrice = 15990000
    },
    new ThbProduct
    {
        ThbProductId = "SP008",
        ThbProductName = "ASUS Vivobook 15",
        ThbYearRelease = "2024",
        ThbPrice = 14990000
    },
    new ThbProduct
    {
        ThbProductId = "SP009",
        ThbProductName = "Lenovo IdeaPad 5",
        ThbYearRelease = "2023",
        ThbPrice = 13990000
    },
    new ThbProduct
    {
        ThbProductId = "SP010",
        ThbProductName = "HP Pavilion 14",
        ThbYearRelease = "2024",
        ThbPrice = 16990000
    }
        };
        public IActionResult Index()
        {
            return Json(_products);
        }

        public IActionResult ThbGetAllproduct()
        {
            ViewData["products"] = _products;
            return View();
        }
        public IActionResult ThbGetListproduct()
        {
      
            return View(_products);
        }
    }
}
