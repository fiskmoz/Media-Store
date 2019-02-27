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
        private Validator validator;
        
        public Inventory()
        {
            ProductSelection = new List<Product>();
            CurrentProducts = new List<Product>();

            fileManager = new FileManager();
            validator = new Validator();

            CurrentProducts = fileManager.ReadFromFile(CurrentProducts);

            ProductSelection.Add(new Book("1", "Default", 0, "Default", 0, "Default", 0));
            ProductSelection.Add(new Movie("2", "Default", 0, "Default", 0, "Default", "Default"));
            ProductSelection.Add(new CD("3", "Default", 0, "Default", 0, "Default"));
            ProductSelection.Add(new Game("4", "Default", 0, "Default", 0, "Default"));
        }

        internal int CreateProduct(string type, List<string> str)
        {
            int code = validator.CreateValidation(str, CurrentProducts);
            if (code != 10)
                return code;
            switch (type)
            {
                case "Book":
                    if (!validator.IntParsing(str[5]))
                        return 5;
                    CurrentProducts.Add(new Book(str[0], str[1], float.Parse(str[2]), str[3], 0, str[4], Int32.Parse(str[5])));
                    break;
                case "Movie":
                    CurrentProducts.Add(new Movie(str[0], str[1], float.Parse(str[2]), str[3], 0, str[4], str[5]));
                    break;
                case "CD":
                    CurrentProducts.Add(new CD(str[0], str[1], float.Parse(str[2]), str[3], 0, str[4]));
                    break;
                case "Game":
                    CurrentProducts.Add(new Game(str[0], str[1], float.Parse(str[2]), str[3], 0, str[4]));
                    break;
            }
            fileManager.WriteToFile(CurrentProducts);
            return 10;
        }

        internal int RemoveProduct(List<string> str)
        {
            foreach(var prod in CurrentProducts)
            {
                if(prod.uniqueID == str[0])
                {
                    CurrentProducts.Remove(prod);
                    fileManager.WriteToFile(CurrentProducts);
                    return 10;
                }
            }
            return 6;
        }

        internal int GetCopies(string ID)
        {
            foreach(var prod in CurrentProducts)
            {
                if (prod.uniqueID == ID)
                    return prod.copies;
            }
            return 0;
        }

        internal int OrderMoreProducts(List<string> str)
        {
            if(!validator.IntParsing(str[1]))
                return 7;

            foreach(var prod in CurrentProducts)
            {
                if(prod.uniqueID == str[0])
                {
                    prod.copies += Int32.Parse(str[1]);
                    fileManager.WriteToFile(CurrentProducts);
                    return 10;
                }
            }
            return 8;
        }

    }
}
