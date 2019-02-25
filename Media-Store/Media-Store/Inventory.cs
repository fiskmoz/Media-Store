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

        internal void CreateBook(List<string> str)
        {
            CurrentProducts.Add(new Book(str[0], str[1], float.Parse(str[2]), str[3], 0 , str[4], Int32.Parse(str[5])));
            fileManager.WriteToFile(CurrentProducts);
        }
        internal void CreateMovie(List<string> str)
        {
            CurrentProducts.Add(new Movie(str[0], str[1], float.Parse(str[2]), str[3], 0, str[4], str[5]));
            fileManager.WriteToFile(CurrentProducts);
        }
        internal void CreateCD(List<string> str)
        {
            CurrentProducts.Add(new CD(str[0], str[1], float.Parse(str[2]), str[3], 0, str[4]));
            fileManager.WriteToFile(CurrentProducts);
        }
        internal void CreateGame(List<string> str)
        {
            CurrentProducts.Add(new CD(str[0], str[1], float.Parse(str[2]), str[3], 0, str[4]));
            fileManager.WriteToFile(CurrentProducts);
        }
        internal void RemoveProduct(List<string> str)
        {
            foreach(var prod in CurrentProducts)
            {
                if(prod.uniqueID == str[0])
                {
                    CurrentProducts.Remove(prod);
                    return;
                }
            }
        }
    }
}
