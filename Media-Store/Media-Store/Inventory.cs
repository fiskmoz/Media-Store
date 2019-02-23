using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Store
{
    class Inventory
    {
        public List<Product> ProductSelection;
        public List<Product> CurrentProducts;

        private FileManager fileManager;
        
        public Inventory()
        {
            ProductSelection = new List<Product>();
            CurrentProducts = new List<Product>();

            fileManager = new FileManager();
            CurrentProducts = fileManager.ReadFromFile(CurrentProducts);

            ProductSelection.Add(new Book("1", "Default", 0, "Default", 0, "Default", 0));
            ProductSelection.Add(new Movie("2", "Default", 0, "Default", 0, "Default", "Default"));
            ProductSelection.Add(new CD("3", "Default", 0, "Default", 0, "Default"));
            ProductSelection.Add(new Game("4", "Default", 0, "Default", 0, "Default"));
        }

        internal void CreateBook(object obj, StringListEventArgs e)
        {
            CurrentProducts.Add(new Book(e.str[0], e.str[1], float.Parse(e.str[2]), e.str[3], 0 , e.str[4], Int32.Parse(e.str[5])));
            fileManager.WriteToFile(CurrentProducts);
        }
        internal void CreateMovie(object obj, StringListEventArgs e)
        {
            CurrentProducts.Add(new Movie(e.str[0], e.str[1], float.Parse(e.str[2]), e.str[3], 0, e.str[4], e.str[5]));
            fileManager.WriteToFile(CurrentProducts);
        }
        internal void CreateCD(object obj, StringListEventArgs e)
        {
            CurrentProducts.Add(new CD(e.str[0], e.str[1], float.Parse(e.str[2]), e.str[3], 0, e.str[4]));
            fileManager.WriteToFile(CurrentProducts);
        }
        internal void CreateGame(object obj, StringListEventArgs e)
        {
            CurrentProducts.Add(new CD(e.str[0], e.str[1], float.Parse(e.str[2]), e.str[3], 0, e.str[4]));
            fileManager.WriteToFile(CurrentProducts);
        }
    }
}
