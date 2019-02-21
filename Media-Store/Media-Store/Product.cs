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

        public Product(int uniqueID, string name, float price, string publisher)
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
        public Book(int uniqueID, string name, float price, string publisher, string author, int version) 
            : base (uniqueID, name, price, publisher)
        {
            this.author = author;
            this.version = version;
        }
    }
    
    class Movie : Product
    {
        public string director;
        public string mainActor;
        public Movie(int uniqueID, string name, float price, string publisher, string director, string mainActor)
                : base(uniqueID, name, price, publisher)
        {
            this.director = director;
            this.mainActor = mainActor;
        }
    }

    class CD : Product
    {
        public string singerOrBand;
        public CD(int uniqueID , string name, float price, string publisher, string singerOrBand)
            : base(uniqueID, name, price, publisher)
        {
            this.singerOrBand = singerOrBand;
        }
    }

    class Game : Product
    {
        public string studio;
        public Game(int uniqueID, string name, float price, string publisher,  string studio)
            : base(uniqueID, name, price, publisher)
        {
            this.studio = studio;
        }
    }
}
