using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Store
{
    class Inventory
    {
        public List<Product> ProductSelection;

        public List<Product> CurrentProducts;
        public List<Product> CurrentInventory; 
        
        public Inventory()
        {
            ProductSelection = new List<Product>();
            ProductSelection.Add(new Book(0, "Default", 0, "Default", "Default", 0));
            ProductSelection.Add(new Movie(1, "Default", 0, "Default", "Default", "Default"));
            ProductSelection.Add(new CD(2, "Default", 0, "Default", "Default"));
            ProductSelection.Add(new Game(3, "Default", 0, "Default", "Default"));
            ProductSelection.Add(new Game(4, "Default", 0, "Default", "Default"));
        }

        internal void CreateBook(object obj, StringListEventArgs e)
        {
            // REMEMBER TO DO SAFETY CHECKS, MAYBE IN A FUNCTION OR SOMETHING
            var id = Int32.Parse(e.str[0]);
            var name = e.str[1];
            var price = float.Parse(e.str[2]);
            var publisher = e.str[3];
            var author = e.str[4];
            var version = Int32.Parse(e.str[5]);

            CurrentProducts.Add(new Book(id, name, price, publisher, author, version));
        }
        internal void CreateMovie(object obj, StringListEventArgs e)
        {
            var id = Int32.Parse(e.str[0]);
            var name = e.str[1];
            var price = float.Parse(e.str[2]);
            var publisher = e.str[3];
            var director = e.str[4];
            var leadActor = e.str[5];

            CurrentProducts.Add(new Movie(id, name, price, publisher, director, leadActor));
        }
        internal void CreateCD(object obj, StringListEventArgs e)
        {
            var id = Int32.Parse(e.str[0]);
            var name = e.str[1];
            var price = float.Parse(e.str[2]);
            var publisher = e.str[3];
            var singer = e.str[4];

            CurrentProducts.Add(new CD(id, name, price, publisher, singer));
        }
        internal void CreateGame(object obj, StringListEventArgs e)
        {
            var id = Int32.Parse(e.str[0]);
            var name = e.str[1];
            var price = float.Parse(e.str[2]);
            var publisher = e.str[3];
            var studio = e.str[4];

            CurrentProducts.Add(new CD(id, name, price, publisher, studio));
        }
    }
}
