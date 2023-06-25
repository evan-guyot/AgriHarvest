using AgriHarvest.Api.Models;
using AgriHarvest.Api.Services.ObjectServices.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace AgriHarvest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService )
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Product>))]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return Ok(_productService.GetAll());
        }


        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Product>> GetById(int id)
        {
            var product = _productService.GetById(id);
            return product == null ? NotFound() : Ok(product);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Post(string name, float price, string libelle, int? idCategory)
        {
            //try
            //{
            //    if (idCategory == null)
            //    {
            //        _productService.Add(new Product(null, name, price, libelle, null));
            //        return Ok();
            //    }
            //    else
            //    {
            //        var category = _categories.FirstOrDefault(c => c.Id == idCategory);

            //        if (category == null)
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            _products.ToList().Add(new Product(null, name, price, libelle, category));
            //            return Ok();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    _logger.LogError(ex.Message);
            //    return BadRequest();
            //}
            throw new NotImplementedException();
        }
    }
}
