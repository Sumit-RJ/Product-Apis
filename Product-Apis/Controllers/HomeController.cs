using Microsoft.AspNetCore.Mvc;
using Product_Apis.DTOs;
using Product_Apis.Models;
using Product_Apis.Repository;

namespace Product_Apis.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository) 
        { 
            _productRepository = productRepository;
        }

        [HttpPost]
        public CreatedAtActionResult CreateProduct(ProductDTO product)
        {
            ProductDTO pr = _productRepository.AddProduct(product);
            return CreatedAtAction(nameof(GetProductOnId), new { id = pr.Id }, pr);
        }

        [HttpGet]
        [Route("GetProductOnId")]
        public ActionResult GetProductOnId(int id) 
        {
            ProductDTO item = _productRepository.GetProductById(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpGet]
        [Route("GetAllProducts")]
        public ActionResult GetAllProducts()
        {
            List<ProductDTO> item = _productRepository.GetAllProducts();
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

    }
}
