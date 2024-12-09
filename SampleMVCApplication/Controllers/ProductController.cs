using Microsoft.AspNetCore.Mvc;
using SampleMVCApplication.Models;

namespace SampleMVCApplication.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        static List<ProductViewModel> Products = new List<ProductViewModel>() { 
            new ProductViewModel() { ProductId=1001, ProductCode="P001", ProductName="Laptop" , ProductDescription="Laptop", Price=1200 } };
        [Route("GetInfo")]
        public IActionResult GetProductInfo()
        {
            ProductViewModel productViewModel = new ProductViewModel() { Price = 10, ProductCode = "PRD001", ProductId = 1001, ProductDescription = "Sample Product", ProductName = "Sample Product" };
           // ViewData["Product"] = productViewModel;
            return View(productViewModel);
        }

        [Route("Add")]
        [HttpGet]
        public IActionResult Create() { 
            return View("CreateV1");
        }

        [Route("Save")]
        [HttpPost]
        public IActionResult SaveProduct(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                Products.Add(productViewModel);
                //return View();
                return RedirectToAction("ProductList");
            }
            return View("CreateV1");
        }

        [Route("ProductList")]
        [HttpGet]
        public IActionResult ProductList()
        {
            return View("ProductCard",Products);
        }
    }
}
