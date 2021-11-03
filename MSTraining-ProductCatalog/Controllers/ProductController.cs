using Microsoft.AspNetCore.Mvc;
using MSTraining_ProductCatalog.Domain;
using MSTraining_ProductCatalog.Mappers;
using MSTraining_ProductCatalog.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MSTraining_ProductCatalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _ProductRepository;

        public ProductController(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var productEF = _ProductRepository.GetAllProducts();

            return ProductMapper.Map(productEF);
        }

        [HttpPost]
        public void Post(Product products)
        {
            _ProductRepository.CreateProducts(ProductMapper.Map(products));

        }

        [HttpPut]
        public void Edit(Product product)
        {
            _ProductRepository.EditProduct(ProductMapper.Map(product), product.Id);

        }

    }
}
