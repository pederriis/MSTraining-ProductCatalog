using MSTraining_ProductCatalog.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSTraining_ProductCatalog.Persistence.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<ProductEF> GetAllProducts();
        ProductEF GetAllSingleProduct(int productId);

        void CreateProducts(ProductEF productEF);
        void EditProduct(ProductEF productEF, int productsId);
    }
}
