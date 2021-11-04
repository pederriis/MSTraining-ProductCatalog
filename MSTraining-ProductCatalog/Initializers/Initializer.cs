using MSTraining_ProductCatalog.Persistence.Contexts;
using MSTraining_ProductCatalog.Persistence.Models;
using MSTraining_ProductCatalog.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSTraining_ProductCatalog.Initializers
{
    
    public class Initializer
    {
      

        public static void SeedDatabase(ProductCatalogContext productCatalogContext)
        {
            //sikrer sig at databasen eksisterer og skaber, den hvis den ikke gør
            productCatalogContext.Database.EnsureCreated();

            //seeder databasen, hvis den er tom
            if (!productCatalogContext.Products.Any())
            {

                List<ProductEF> products = new List<ProductEF> {
                new ProductEF { Name = "Havregryn", Price = 10 },
                new ProductEF { Name = "Tandpasta", Price = 20 },
                new ProductEF { Name = "Mælk", Price = 15 },
                new ProductEF { Name = "Pasta", Price = 20 },
                new ProductEF { Name = "Leverposteg", Price = 17 },
                new ProductEF { Name = "Kogt torsk", Price = 50 },

            };

                foreach (var p in products)
                {
                    productCatalogContext.Add(p);
                }
                productCatalogContext.SaveChanges();
            }


            


        }
    }
}
