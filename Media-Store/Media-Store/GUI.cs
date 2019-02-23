using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Store
{
    public partial class GUI : Form
    {
        public event EventHandler<StringListEventArgs> CreateBook;
        public event EventHandler<StringListEventArgs> CreateMovie;
        public event EventHandler<StringListEventArgs> CreateCD;
        public event EventHandler<StringListEventArgs> CreateGame;
        public event EventHandler<StringListEventArgs> alertStore;

        public GUI()
        {
            InitializeComponent();
        }

        private void addProductBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(addProductBox.SelectedIndex)
            {
                case 0:
                    label4.Text = "Author: ";
                    label5.Text = "Version: ";
                    textBox6.Visible = true;
                    break;
                case 1:
                    label4.Text = "Director: ";
                    label5.Text = "Lead Actor: ";
                    textBox6.Visible = true;
                    break;
                case 2:
                    label4.Text = "Band: ";
                    label5.Text = "";
                    textBox6.Visible = false;
                    textBox6.Text = "";
                    break;
                case 3:
                    label4.Text = "Studio: ";
                    label5.Text = "";
                    textBox6.Visible = false;
                    textBox6.Text = "";
                    break;
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            if(!ValidateInput())
            {
                // DISPLAY ERROR MESSAGE
                return;
            }
            StringListEventArgs ev = new StringListEventArgs();
            ev.str.Add(textBox1.Text);
            ev.str.Add(textBox2.Text);
            ev.str.Add(textBox3.Text);
            ev.str.Add(textBox3.Text);
            ev.str.Add(textBox5.Text);
            switch (addProductBox.SelectedIndex)
            {
                case 0:
                    try
                    {
                        Int32.Parse(textBox6.Text);
                    }
                    catch(Exception f)
                    {
                        return;
                    }
                    ev.str.Add(textBox6.Text);
                    CreateBook(this, ev);
                    break;
                case 1:
                    ev.str.Add(textBox6.Text);
                    CreateMovie(this, ev);
                    break;
                case 2:
                    CreateCD(this, ev);
                    break;
                case 3:
                    CreateGame(this, ev);
                    break;
            }
        }

        private void removeProductButton_Click(object sender, EventArgs e)
        {

        }
        
        internal void CreateNewSetSelection(List<Product> list)
        {
            addProductBox.DataSource = list;
        }

        internal void UpdateCurrentInventory(List<Product> list)
        {
            productListView.Items.Clear();
            removeProductBox.Items.Clear();
            foreach(Product pro in list)
            {
                productListView.Items.Add(pro.uniqueID);
                removeProductBox.Items.Add(pro.uniqueID);
            }
        }

        internal void UpdateSuccessLabel(bool result)
        {
            if(result)
            {
                // DISPLAY SUCCESS
                return;
            }
            // DISPLAY FAILURE
            return;
        }
        
        private bool ValidateInput()
        {
            var text = textBox1.Text; 
            foreach(string entry in productListView.Items)
            {
                if(entry == text)
                {
                    return false;
                }
            }
            var price = textBox3.Text;
            try
            {
                float.Parse(price);
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
