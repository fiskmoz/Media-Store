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
        public event EventHandler<EventArgs> alertStock;
        public event EventHandler<EventArgs> alertStore;

        public GUI()
        {
            InitializeComponent();
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox9.ReadOnly = true;
        }

        private void addProductBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(addProductBox.SelectedIndex)
            {
                case 0:
                    textBox4.ReadOnly = false;
                    textBox5.ReadOnly = false;
                    textBox6.ReadOnly = true;
                    textBox7.ReadOnly = true;
                    textBox8.ReadOnly = true;
                    textBox9.ReadOnly = true;
                    break;
                case 1:
                    textBox4.ReadOnly = true;
                    textBox5.ReadOnly = true;
                    textBox6.ReadOnly = false;
                    textBox7.ReadOnly = false;
                    textBox8.ReadOnly = true;
                    textBox9.ReadOnly = true;
                    break;
                case 2:
                    textBox4.ReadOnly = true;
                    textBox5.ReadOnly = true;
                    textBox6.ReadOnly = true;
                    textBox7.ReadOnly = true;
                    textBox8.ReadOnly = false;
                    textBox9.ReadOnly = true;
                    break;
                case 3:
                    textBox4.ReadOnly = false;
                    textBox5.ReadOnly = false;
                    textBox6.ReadOnly = true;
                    textBox7.ReadOnly = true;
                    textBox8.ReadOnly = true;
                    textBox9.ReadOnly = false;
                    break;
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "GRABIT";
            textBox2.Text = "GRABIT";
            textBox3.Text = "GRABIT";
            switch (addProductBox.SelectedIndex)
            {
                case 0:
                    textBox4.Text = "GRABIT";
                    textBox5.Text = "GRABIT";

                    break;
                case 1:
                    textBox6.Text = "GRABIT";
                    textBox7.Text = "GRABIT";
                    break;
                case 2:
                    textBox8.Text = "GRABIT";
                    break;
                case 3:
                    textBox9.Text = "GRABIT";
                    break;
            }
        }

        private void removeProductButton_Click(object sender, EventArgs e)
        {

        }
        
        internal void CreateNewSetSelection(List<Product> list)
        {
            ComboBox cb = (ComboBox)tabControl.TabPages[1].Controls[20];
            cb.DataSource = list;
        }
    }
}
