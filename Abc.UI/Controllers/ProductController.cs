
using Abc.Business.Abstract;
using Abc.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Abc.UI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            var products = _productService.GetAll();
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products
            };

            return View(model);
        }
    }
}
