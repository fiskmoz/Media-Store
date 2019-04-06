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
            string text = System.IO.File.ReadAllText(serializationFile);

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
            }

            
        }

        internal void WriteToFile(List<Product> list)
        {
            using (Stream stream = File.Open(serializationFile, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                try
                {
                    bformatter.Serialize(stream, list);
                }
                catch(Exception e)
                {

                }
            }
        }
    }
}
