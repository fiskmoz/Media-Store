using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Store
{
    [Serializable]
    class Order
    {
        public List<Product> list = new List<Product>();
        public List<int> ToBuy = new List<int>();
    }

    public class StringListEventArgs : EventArgs
    {
        public List<string> str = new List<string>();
    }

    public class ProductListEventArgs : EventArgs
    {
        public List<Product> products = new List<Product>();
        public List<int> ToBuy = new List<int>();
    }
}
