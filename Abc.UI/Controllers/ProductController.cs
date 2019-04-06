
using Abc.Business.Abstract;
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
            return View();
        }
    }
}
