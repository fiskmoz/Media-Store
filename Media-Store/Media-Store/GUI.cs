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
        public event EventHandler<StringListEventArgs> RemoveProduct;
        public event EventHandler<StringListEventArgs> OrderMoreProducts;

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
                    label5.Text = "Actor: ";
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
            StringListEventArgs ev = new StringListEventArgs();
            ev.str.Add(textBox1.Text);
            ev.str.Add(textBox2.Text);
            ev.str.Add(textBox3.Text);
            ev.str.Add(textBox4.Text);
            ev.str.Add(textBox5.Text);
            switch (addProductBox.SelectedIndex)
            {
                case 0:
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
            var args = new StringListEventArgs();
            args.str.Add((string)removeProductBox.SelectedItem);
            RemoveProduct(this, args);
        }


        private void orderMoreButton_Click(object sender, EventArgs e)
        {
            var args = new StringListEventArgs();
            args.str.Add((string)orderMoreComboBox.SelectedItem);
            args.str.Add((string)orderMoreTextBox.Text);
            OrderMoreProducts(this, args);
        }

        internal void CreateNewSetSelection(List<Product> list)
        {
            addProductBox.DataSource = list;
        }

        internal void UpdateCurrentInventory(List<Product> list)
        {
            productListView.Items.Clear();
            removeProductBox.Items.Clear();
            orderMoreComboBox.Items.Clear();
            foreach (Product pro in list)
            {
                productListView.Items.Add(pro.GetType().ToString().Replace("Media_Store.", "") + ":  " + pro.uniqueID + "         Copies: " + pro.copies.ToString());
                removeProductBox.Items.Add(pro.uniqueID);
                orderMoreComboBox.Items.Add(pro.uniqueID);
            }
        }

        internal void UpdateSuccessLabel(int errorCode)
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label10.ForeColor = Color.Black;
            label11.ForeColor = Color.Black;
            switch (errorCode)
            {
                case 0:
                    statusLabel.Text = "Status: Invalid identifier";
                    statusLabel.ForeColor = Color.Red;
                    label10.ForeColor = Color.Red;
                    break;
                case 1:
                    statusLabel.Text = "Status: Invalid name";
                    statusLabel.ForeColor = Color.Red;
                    label1.ForeColor = Color.Red;
                    break;
                case 2:
                    statusLabel.Text = "Status: Invalid price";
                    statusLabel.ForeColor = Color.Red;
                    label2.ForeColor = Color.Red;
                    break;
                case 3:
                    statusLabel.Text = "Status: Invalid publisher";
                    statusLabel.ForeColor = Color.Red;
                    label3.ForeColor = Color.Red;
                    break;
                case 4:
                    statusLabel.Text = "Status: Invalid author/director/band/studio";
                    statusLabel.ForeColor = Color.Red;
                    label4.ForeColor = Color.Red;
                    break;
                case 5:
                    statusLabel.Text = "Status: Invalid actor/version";
                    statusLabel.ForeColor = Color.Red;
                    label5.ForeColor = Color.Red;
                    break;
                case 6:
                    statusLabel.Text = "Status: Invalid target";
                    statusLabel.ForeColor = Color.Red;
                    label11.ForeColor = Color.Red;
                    break;
                case 7:
                    statusLabel.Text = "Status: Invalid number of copies";
                    statusLabel.ForeColor = Color.Red;
                    label7.ForeColor = Color.Red;
                    break;
                case 8:
                    statusLabel.Text = "Status: Invalid target";
                    statusLabel.ForeColor = Color.Red;
                    label6.ForeColor = Color.Red;
                    break;
                case 10:
                    statusLabel.Text = "Status: OK";
                    statusLabel.ForeColor = Color.Green;
                    break;
            }
            return;
        }
    }
}
