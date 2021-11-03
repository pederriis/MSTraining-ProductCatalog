using MSTraining_ProductCatalog.Persistence.Contexts;
using MSTraining_ProductCatalog.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSTraining_ProductCatalog.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductCatalogContext _Context;


        public ProductRepository(ProductCatalogContext context)
        {
            _Context = context;
        }
        public IEnumerable<ProductEF> GetAllProducts()
        {
            var products = _Context.Products.ToList();

            return products;
        }
        
        public void CreateProducts(ProductEF productEF)
        {
            _Context.Add(productEF);

            _Context.SaveChanges();
        }


        public void EditProduct(ProductEF productEF, int productId)
        {
            ProductEF product = _Context.Products.FirstOrDefault(x => x.Id == productId);

            product.Name = productEF.Name;
            product.Price = productEF.Price;


            _Context.SaveChanges();
        }

    }
}
