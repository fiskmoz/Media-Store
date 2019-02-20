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

        public Product(string name, float price, string publisher, int uniqueID)
        {
            this.name = name;
            this.price = price;
            this.publisher = publisher;
            this.uniqueID = uniqueID;
        }
    }

    class Book : Product
    {
        public string author;
        public int version;
        public Book(string name, float price, string publisher, int uniqueID, string author, int version) 
            : base (name, price, publisher, uniqueID)
        {
            this.author = author;
            this.version = version;
        }
    }
    
    class Movie : Product
    {
        public string director;
        public string mainActor;
        public Movie(string name, float price, string publisher, int uniqueID, string director, string mainActor)
                : base(name, price, publisher, uniqueID)
        {
            this.director = director;
            this.mainActor = mainActor;
        }
    }

    class CD : Product
    {
        public string singerOrBand;
        public CD(string name, float price, string publisher, int uniqueID, string singerOrBand)
            : base(name, price, publisher, uniqueID)
        {
            this.singerOrBand = singerOrBand;
        }
    }

    class Game : Product
    {
        public string studio;
        public Game(string name, float price, string publisher, int uniqueID, string studio)
            : base(name, price, publisher, uniqueID)
        {
            this.studio = studio;
        }
    }
}
