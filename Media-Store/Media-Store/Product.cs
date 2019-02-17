using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Store
{
    class Product
    {
        public string name;
        public float price;
        public string publisher;
        public int uniqueID; 
    }

    class Book : Product
    {
        public string author;
        public int version;
    }
    
    class Movie : Product
    {
        public string director;
        public string mainActor;
    }

    class CD : Product
    {
        public string singerOrBand;
    }

    class Game : Product
    {
        public string studio;
    }
}
