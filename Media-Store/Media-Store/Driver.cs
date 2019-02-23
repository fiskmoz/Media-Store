using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Store
{
    class Driver
    {
        private GUI gui;
        private Inventory inventory;

        public Driver()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            gui = new GUI();
            inventory = new Inventory();
            gui.CreateNewSetSelection(inventory.ProductSelection);
            gui.UpdateCurrentInventory(inventory.CurrentProducts);
            SetListeners();
            Application.Run(gui);
        }

        private void SetListeners()
        {
            gui.CreateBook += new EventHandler<StringListEventArgs>(CreateBookEvent);
            gui.CreateMovie += new EventHandler<StringListEventArgs>(inventory.CreateMovie);
            gui.CreateCD += new EventHandler<StringListEventArgs>(inventory.CreateCD);
            gui.CreateGame += new EventHandler<StringListEventArgs>(inventory.CreateGame);
        }

        private void CreateBookEvent(object obj, StringListEventArgs e)
        {
            inventory.CreateBook(obj, e);
            gui.UpdateCurrentInventory(inventory.CurrentProducts);
        }
    }

    public class StringListEventArgs : EventArgs
    {
        public List<string> str = new List<string>();
    }
}
