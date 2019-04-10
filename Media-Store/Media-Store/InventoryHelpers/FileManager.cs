using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Store
{
    class FileManager
    {
        private string serializationFile;

        public FileManager()
        {
            serializationFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Inventory.txt");
        }

        internal List<Product> ReadFromFile(List<Product> list)
        {
            using (var stream = new StreamReader(serializationFile))
            {
                string line;
                while((line = stream.ReadLine()) != null)
                {
                    var strList = line.Split(';');
                    switch(strList[0])
                    {
                        case "Movie":
                            list.Add(new Movie(strList[1], strList[2], float.Parse(strList[3]), strList[4], Int32.Parse(strList[5]), strList[6], strList[7]));
                            break;
                        case "CD":
                            break;
                        case "Game":
                            break;
                        case "Book":
                            break;
                        
                    }
                }
            }

            return list;
            //list = text.Split(';');
            /*
            try
            {
                using (Stream stream = File.Open(serializationFile, FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    try
                    {
                        list = (List<Product>)bformatter.Deserialize(stream);
                    }
                    catch (Exception e)
                    {

                    }
                    return list;
                }
        }
            catch(Exception e)
            {
                using (Stream stream = File.Open(serializationFile, FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    try
                    {
                        list = (List<Product>)bformatter.Deserialize(stream);
                    }
                    catch (Exception g)
                    {

                    }
                    return list;
                }
            }*/
        }

        internal void WriteToFile(List<Product> list)
        {
            using (var stream = new StreamWriter(serializationFile, false))
            {
                foreach (Product prod in list)
                {
                    string str = prod.GetType().ToString() + prod.uniqueID + ";" + prod.name + ";" + prod.publisher + ";" + prod.price.ToString() + ";" + prod.copies.ToString() + ";";
                    if(prod.GetType().Equals(typeof(Movie)))
                    {
                        Movie movie = (Movie)prod;
                        str += movie.director + ';' + movie.mainActor;
                    }
                    else if (prod.GetType().Equals(typeof(Book)))
                    {
                        Book book = (Book)prod;
                        str += book.author + ';' + book.version.ToString();
                    }
                    else if (prod.GetType().Equals(typeof(CD)))
                    {
                        CD cd = (CD)prod;
                        str += cd.singerOrBand;
                    }
                    else if (prod.GetType().Equals(typeof(Game)))
                    {
                        Game movie = (Game)prod;
                        str += movie.studio;
                    }
                    stream.WriteLine(str);
                }
                stream.Close();
            }
        }
    }
}
