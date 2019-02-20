using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Store
{
    class Inventory
    {
        public List<Product> CurrentInventory;
        public List<Product> AvalibleProducts;
        public Inventory()
        {
            AvalibleProducts = new List<Product>();
            AvalibleProducts.Add(new Book("Default", 0, "Default", 0, "Default", 0));
            AvalibleProducts.Add(new Movie("Default", 0, "Default", 1, "Default", "Default"));
            AvalibleProducts.Add(new CD("Default", 0, "Default", 2, "Default"));
            AvalibleProducts.Add(new Game("Default", 0, "Default", 3, "Default"));
        }
    }
}
