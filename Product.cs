using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem
{
    abstract class Product
    {
        public string Quantity { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public virtual string Description { get; set; }
    }

    enum ProductCategory
    {
        Game,
        Book,
        Movie
    }
}
