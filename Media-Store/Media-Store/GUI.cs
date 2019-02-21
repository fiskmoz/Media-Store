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
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox9.ReadOnly = true;
            textBox10.ReadOnly = true;
        }

        private void addProductBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(addProductBox.SelectedIndex)
            {
                case 0:
                    textBox5.ReadOnly = false;
                    textBox6.ReadOnly = false;
                    textBox7.ReadOnly = true;
                    textBox8.ReadOnly = true;
                    textBox9.ReadOnly = true;
                    textBox10.ReadOnly = true;
                    break;
                case 1:
                    textBox5.ReadOnly = true;
                    textBox6.ReadOnly = true;
                    textBox7.ReadOnly = false;
                    textBox8.ReadOnly = false;
                    textBox9.ReadOnly = true;
                    textBox10.ReadOnly = true;
                    break;
                case 2:
                    textBox5.ReadOnly = true;
                    textBox6.ReadOnly = true;
                    textBox7.ReadOnly = true;
                    textBox8.ReadOnly = true;
                    textBox9.ReadOnly = false;
                    textBox10.ReadOnly = true;
                    break;
                case 3:
                    textBox5.ReadOnly = false;
                    textBox6.ReadOnly = false;
                    textBox7.ReadOnly = true;
                    textBox8.ReadOnly = true;
                    textBox9.ReadOnly = true;
                    textBox10.ReadOnly = false;
                    break;
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            StringListEventArgs ev = new StringListEventArgs();
            ev.str.Add(textBox1.Text);
            ev.str.Add(textBox2.Text);
            ev.str.Add(textBox3.Text);
            ev.str.Add(textBox3.Text);
            switch (addProductBox.SelectedIndex)
            {
                case 0:
                    ev.str.Add(textBox5.Text);
                    ev.str.Add(textBox6.Text);
                    CreateBook(this, ev);
                    break;
                case 1:
                    ev.str.Add(textBox7.Text);
                    ev.str.Add(textBox8.Text);
                    CreateMovie(this, ev);
                    break;
                case 2:
                    ev.str.Add(textBox9.Text);
                    CreateCD(this, ev);
                    break;
                case 3:
                    ev.str.Add(textBox10.Text);
                    CreateGame(this, ev);
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
