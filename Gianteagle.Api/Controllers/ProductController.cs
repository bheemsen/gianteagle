using Gianteagle.BAL.IServices;
using Gianteagle.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gianteagle.Api.Controllers
{

    [ApiController]
    public class ProductController : BaseController
    {
        private readonly IProductService productService;
        public ProductController(IProductService iproductService)
        {
            this.productService = iproductService;
        }
        [HttpGet]
        [Route("GetProduct/{upcCode}")]
        public IActionResult GetProduct(long upcCode)
        {
            var product = this.productService.GetProduct(upcCode);
            if (product != null)
            {
                return Ok(product);
            }
            else
            {
                return NotFound($"Product with UPC code {upcCode} does not exists");
            }
        }
        [HttpGet]
        [Route("GetProducts")]
        public List<Product> GetProducts()
        {
            var a = User.Identity;
            return this.productService.GetProducts();
        }
        [HttpGet]
        [Route("RefreshProducts")]
        public void RefreshProducts()
        {
            this.productService.GetProducts();
        }
    }
}
