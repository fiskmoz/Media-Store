using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Store
{
    class GUIHelper
    {
        private GUI Gui;

        public GUIHelper(GUI GUI)
        {
            Gui = GUI;
        }

        public void PrintDoc()
        {
            PrintDialog printDialog = new PrintDialog(); //make a printDialog object

            PrintDocument printDocument = new PrintDocument(); // make a print doc object

            printDialog.Document = printDocument; //document for printing is printDocument

            printDocument.PrintPage += printDocument_PrintPage; //event handler fire

            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }

        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs ev)
        {
            Graphics graphic = ev.Graphics;
            foreach (var row in Gui.dataGridStoreP.Rows)
            {
                string text = row.ToString(); //or whatever you want from the current row
                graphic.DrawString(text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, 20, 225);
            }
        }

        internal bool DisplayRemoveAlert()
        {
            string messageBoxText = "You still have copies of this product, do you still want to delete? ";
            string caption = "Remove product alert";
            MessageBoxButtons button = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show(messageBoxText, caption, button, icon);
            switch (result)
            {
                case DialogResult.Yes:
                    return true;
                case DialogResult.No:
                case DialogResult.Cancel:
                    return false;
            }
            return false;
        }

        internal DataTable CreateTable(List<Product> list)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Type", typeof(string));
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Price", typeof(float));
            table.Columns.Add("Publisher", typeof(string));
            table.Columns.Add("Copies", typeof(int));
            table.Columns.Add("Entry5", typeof(string));
            table.Columns.Add("Entr6", typeof(string));
            foreach (var entry in list)
            {
                // ADD UNIQUE THINGS HERE LATER
                switch (entry.GetType().ToString().Replace("Media_Store.", ""))
                {
                    case "Book":
                        table.Rows.Add(entry.GetType().ToString().Replace("Media_Store.", ""), entry.uniqueID, entry.name, entry.price, entry.publisher, entry.copies);
                        break;
                    case "Movie":
                        table.Rows.Add(entry.GetType().ToString().Replace("Media_Store.", ""), entry.uniqueID, entry.name, entry.price, entry.publisher, entry.copies);
                        break;
                    case "CD":
                        table.Rows.Add(entry.GetType().ToString().Replace("Media_Store.", ""), entry.uniqueID, entry.name, entry.price, entry.publisher, entry.copies);
                        break;
                    case "Game":
                        table.Rows.Add(entry.GetType().ToString().Replace("Media_Store.", ""), entry.uniqueID, entry.name, entry.price, entry.publisher, entry.copies);
                        break;
                }
            }
            return table;
        }
    }
}
