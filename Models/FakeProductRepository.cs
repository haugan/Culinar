using System.Collections.Generic;

namespace Culinar.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product {Name = "Olive oil", Price = 20},
            new Product {Name = "Black rice", Price = 30},
            new Product {Name = "Chopped lamb", Price = 75}
        };
    }
}
