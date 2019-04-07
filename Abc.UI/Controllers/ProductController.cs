
using Abc.Business.Abstract;
using Abc.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Abc.UI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index(int page = 1)
        {
            int pageSize = 10;

            var products = _productService.GetAll();
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList()
            };

            return View(model);
        }
    }
}
