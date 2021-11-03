using MSTraining_ProductCatalog.Domain;
using MSTraining_ProductCatalog.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSTraining_ProductCatalog.Mappers
{
    public class ProductMapper
    {

        public static IEnumerable<Product> Map(IEnumerable<ProductEF> productEFList)
        {
            List<Product> products = new List<Product>();

            foreach (var p in productEFList)
            {
                products.Add(Map(p));
            }

            return products;

        }

        public static Product Map(ProductEF productsEF)
        {
            Product product = new Product
            {
                Id = productsEF.Id,
                Name = productsEF.Name,
                Price=productsEF.Price
            };

            return product;

        }
        public static ProductEF Map(Product product)
        {
            ProductEF productEF = new ProductEF
            {
                // Id = customer.Id,
                Name = product.Name,
                Price = product.Price,
            };

            return productEF;

        }

    }
}
