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
        [Route("GetProduct")]
        public Product GetProduct(long upcCode)
        {
            return this.productService.GetProduct(upcCode);
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
