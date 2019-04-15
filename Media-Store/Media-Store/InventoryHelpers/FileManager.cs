using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Store
{
    class FileManager
    {
        private string serializationFile;
        private string lastOpen = "";

        public FileManager()
        {
            // PATH!
            serializationFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Inventory.txt");
        }

        // Read from the file and add all entries to the list and return it.
        internal List<Product> ReadFromFile(List<Product> list)
        {
            if(!File.Exists(serializationFile))
            {
                CreateFilePath();
            }
            using (var fileStream = File.Open(serializationFile, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                fileStream.Close();
            }
            using (var stream = new StreamReader(serializationFile))
                {
                    string line;
                    while ((line = stream.ReadLine()) != null)
                    {
                        var split = line.Split(ErrorCodes.SEPARATOR);
                        switch (split[0])
                        {
                            case "Movie":
                                list.Add(new Movie(split[1], split[2], float.Parse(split[3]), split[4], Int32.Parse(split[5]), split[6], split[7]));
                                break;
                            case "CD":
                                list.Add(new CD(split[1], split[2], float.Parse(split[3]), split[4], Int32.Parse(split[5]), split[6]));
                                break;
                            case "Game":
                                list.Add(new Game(split[1], split[2], float.Parse(split[3]), split[4], Int32.Parse(split[5]), split[6]));
                                break;
                            case "Book":
                                list.Add(new Book(split[1], split[2], float.Parse(split[3]), split[4], Int32.Parse(split[5]), split[6], Int32.Parse(split[7])));
                                break;

                        }
                    }
                }
            return list;
        }

        // Save list to file by overwriting everything currently there.
        internal void WriteToFile(List<Product> list)
        {
            if (!File.Exists(serializationFile))
            {
                CreateFilePath();
            }
            using (var stream = new StreamWriter(serializationFile, false))
            {
                foreach (Product prod in list)
                {
                    string str = prod.GetType().ToString().Replace("Media_Store.", "") + ErrorCodes.SEPARATOR + prod.uniqueID + 
                        ErrorCodes.SEPARATOR + prod.publisher + ErrorCodes.SEPARATOR + prod.price.ToString() + 
                        ErrorCodes.SEPARATOR + prod.name + ErrorCodes.SEPARATOR + prod.copies.ToString() + ErrorCodes.SEPARATOR;

                    if(prod.GetType().Equals(typeof(Movie)))
                    {
                        Movie movie = (Movie)prod;
                        str += movie.director + ErrorCodes.SEPARATOR + movie.mainActor;
                    }
                    else if (prod.GetType().Equals(typeof(Book)))
                    {
                        Book book = (Book)prod;
                        str += book.author + ErrorCodes.SEPARATOR + book.version.ToString();
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

        internal int ExportProductRegister(List<Product> list)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select the folder that handles .txt integration!";
            if (lastOpen == "")
            {
                lastOpen = AppDomain.CurrentDomain.BaseDirectory;
            }
            fbd.SelectedPath = lastOpen;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string sSelectedPath = fbd.SelectedPath;
                try
                {
                    File.Copy(serializationFile, sSelectedPath + "/Inventory.txt", true);

                }
                catch
                {

                }
                return ErrorCodes.SUCCESS;
            }
            return ErrorCodes.INVALID_REMOVE_TARGET;
        }

        // If file does not exist for some reason run this.
        internal void CreateFilePath()
        {
            var fileStream = File.Open(serializationFile, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            fileStream.Close();
        }
    }
}
