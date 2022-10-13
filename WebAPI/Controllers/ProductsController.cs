using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]   //ATTRIBUTE
    public class ProductsController : ControllerBase
    {
        //Loosely coupled (Gevşek Bağımlılık) => Soyuta bağımlılık var.
        //naming convension => İsimlendirme standartı
        //IoC Container => İnversion of Control
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            //Dependency chain -- (Bağımlılık zinciri)
            var result = _productService.GetAll();
            return result.Data;
        }
    }
}
