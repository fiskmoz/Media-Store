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
            Application.Run(gui);
            inventory = new Inventory();
        }
    }
}
