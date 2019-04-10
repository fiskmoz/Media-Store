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

        // When clicking create product button. 
        // Faultcheck otherwise add to currentProducts list 
        // Also write the new currentProducts list to file.
        internal int CreateProduct(string type, List<string> str)
        {
            int code = validator.CreateValidation(str, CurrentProducts);
            if (code != ErrorCodes.SUCCESS)
                return code;
            switch (type)
            {
                case "Book":
                    if (!validator.IntParsing(str[5]))
                        return ErrorCodes.INVALID_ENTRY6;
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
            return ErrorCodes.SUCCESS;
        }

        // When clicking remove product button confirm.
        // Remove the product 
        // Update file 
        internal int RemoveProduct(List<string> str)
        {
            foreach(var prod in CurrentProducts)
            {
                if(prod.uniqueID == str[0])
                {
                    CurrentProducts.Remove(prod);
                    fileManager.WriteToFile(CurrentProducts);
                    return ErrorCodes.SUCCESS;
                }
            }
            return ErrorCodes.INVALID_REMOVE_TARGET;
        }

        // When clicking order more products
        // Update the number of specific product and also do faultchecks
        // Write updated list to file.
        internal int OrderMoreProducts(List<string> str)
        {
            if(!validator.IntParsing(str[1]))
                return ErrorCodes.INVALID_ADD_COPIES;
            if (!validator.withinRange(Int32.Parse(str[1])))
                return ErrorCodes.INVALID_OUTOFRANGE;

            foreach (var prod in CurrentProducts)
            {
                if(prod.uniqueID == str[0])
                {
                    prod.copies += Int32.Parse(str[1]);
                    fileManager.WriteToFile(CurrentProducts);
                    return ErrorCodes.SUCCESS;
                }
            }
            return ErrorCodes.INVALID_ADD_TARGET;
        }

        // A fault checker when buying products
        // Returns Codes listed in ErrorCodes.cs
        internal int BuyProductCheck(List<string> str)
        {
            if (!validator.IntParsing(str[1]))
                return ErrorCodes.INVALID_BUY_COPIES;
            if (!validator.withinRange(Int32.Parse(str[1])))
                return ErrorCodes.INVALID_OUTOFRANGE;

            foreach (var prod in CurrentProducts)
            {
                if (prod.uniqueID == str[0])
                {
                    if (prod.copies - Int32.Parse(str[1]) - Int32.Parse(str[2]) < 0)
                        return ErrorCodes.INVALID_PRODUCT_BELOW_ZERO;
                    return ErrorCodes.SUCCESS;
                }
            }
            return ErrorCodes.INVALID_BUY_TARGET;
        }

        // When clicking the buy products button
        // Products = list of products that someone wants to buy
        // toBuy = list of no of of items that someone wants to buy, they directly correlate in array position.
        internal int BuyProducts(List<Product> products, List<int> toBuy)
        {
            var i = 0;
            foreach(Product prod in products)
            {
                foreach(Product product in CurrentProducts)
                {
                    if(prod.uniqueID == product.uniqueID)
                    {
                        product.copies -= toBuy[i];
                    }
                }
                i++;
            }
            return ErrorCodes.SUCCESS;
        }

        // Get the no. of copies for a speicifc ID.
        internal int GetCopies(string ID)
        {
            foreach (var prod in CurrentProducts)
            {
                if (prod.uniqueID == ID)
                    return prod.copies;
            }
            return 0;
        }

        // Return the product for a specific ID.
        internal Product GetProduct(string ID)
        {
            var prod = (from product in CurrentProducts where product.uniqueID == ID select product).ToList<Product>();
            return prod[0];
        }
        
        // Return a list of products filtered by a specific searchTerm.
        internal List<Product> GetProducts(string searchTerm)
        {
            var list = (from prod in CurrentProducts where prod.uniqueID == searchTerm || prod.name == searchTerm || prod.publisher == searchTerm 
                        orderby prod.name ascending select prod).ToList<Product>();
            return list;
        }
    }
}
