using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Store
{
    [Serializable]
    class Product
    {
        public string uniqueID;
        public string name;
        public float price;
        public string publisher;
        public int copies;

        public Product(string uniqueID, string name, float price, string publisher, int copies)
        {
            this.name = name;
            this.price = price;
            this.publisher = publisher;
            this.uniqueID = uniqueID;
            this.copies = copies;
        }
    }
    [Serializable]
    class Book : Product
    {
        public string author;
        public int version;
        public Book(string uniqueID, string name, float price, string publisher, int copies, string author, int version) 
            : base (uniqueID, name, price, publisher, copies)
        {
            this.author = author;
            this.version = version;
        }
    }
    [Serializable]
    class Movie : Product
    {
        public string director;
        public string mainActor;
        public Movie(string uniqueID, string name, float price, string publisher, int copies, string director, string mainActor)
                : base(uniqueID, name, price, publisher, copies)
        {
            this.director = director;
            this.mainActor = mainActor;
        }
    }
    [Serializable]
    class CD : Product
    {
        public string singerOrBand;
        public CD(string uniqueID , string name, float price, string publisher, int copies, string singerOrBand)
            : base(uniqueID, name, price, publisher, copies)
        {
            this.singerOrBand = singerOrBand;
        }
    }
    [Serializable]
    class Game : Product
    {
        public string studio;
        public Game(string uniqueID, string name, float price, string publisher, int copies, string studio)
            : base(uniqueID, name, price, publisher, copies)
        {
            this.studio = studio;
        }
    }
}
