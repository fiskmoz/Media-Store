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
        public event EventHandler<StringListEventArgs> BuyProduct;

        public GUI()
        {
            InitializeComponent();
        }

        private void addProductBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(addProductBox.SelectedIndex)
            {
                case 0:
                    label4.Text = "Book author: ";
                    label5.Text = "Book version: ";
                    textBox6.Visible = true;
                    break;
                case 1:
                    label4.Text = "Movie director: ";
                    label5.Text = "Lead actor: ";
                    textBox6.Visible = true;
                    break;
                case 2:
                    label4.Text = "Band or singer: ";
                    label5.Text = "";
                    textBox6.Visible = false;
                    textBox6.Text = "";
                    break;
                case 3:
                    label4.Text = "Game studio: ";
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

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            var args = new StringListEventArgs();
            args.str.Add((string)buyProductComboBox.SelectedItem);
            args.str.Add((string)copiesToBuyTextBox.Text);
            BuyProduct(this, args);
        }

        internal void CreateNewSetSelection(List<Product> list)
        {
            foreach(var elem in list)
            {
                addProductBox.Items.Add(elem.GetType().ToString().Replace("Media_Store.", ""));
            }
            addProductBox.SelectedIndex = 0;
        }

        internal bool DisplayTextBox()
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

        internal void UpdateCurrentInventory(List<Product> list)
        {
            productListView.Items.Clear();
            productListViewStoreTab.Items.Clear();
            removeProductBox.Items.Clear();
            orderMoreComboBox.Items.Clear();
            buyProductComboBox.Items.Clear();
            productListView.Items.Add(string.Format("{0,-10}{1,-20}{2,-10}", "Type", "ID", "Copies"));
            productListViewStoreTab.Items.Add(string.Format("{0,-10}{1,-20}{2,-10}", "Type", "ID", "Copies"));
            foreach (Product pro in list)
            {
                productListView.Items.Add(string.Format("{0,-10}{1,-20}{2,-10}", pro.GetType().ToString().Replace("Media_Store.", ""), pro.uniqueID, pro.copies.ToString()));
                productListViewStoreTab.Items.Add(string.Format("{0,-10}{1,-20}{2,-10}", pro.GetType().ToString().Replace("Media_Store.", ""), pro.uniqueID, pro.copies.ToString()));
                removeProductBox.Items.Add(pro.uniqueID);
                orderMoreComboBox.Items.Add(pro.uniqueID);
                buyProductComboBox.Items.Add(pro.uniqueID);
            }
            removeProductBox.SelectedIndex = 0;
            orderMoreComboBox.SelectedIndex = 0;
            buyProductComboBox.SelectedIndex = 0;
        }

        internal bool UpdateSuccessLabel(int errorCode)
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
            label20.ForeColor = Color.Black;
            label21.ForeColor = Color.Black;
            switch (errorCode)
            {
                case ErrorCodes.INVALID_IDENTIFER:
                    statusLabel.Text = "Status: Invalid identifier";
                    statusLabel.ForeColor = Color.Red;
                    label10.ForeColor = Color.Red;
                    break;
                case ErrorCodes.INVALID_NAME:
                    statusLabel.Text = "Status: Invalid name";
                    statusLabel.ForeColor = Color.Red;
                    label1.ForeColor = Color.Red;
                    break;
                case ErrorCodes.INVALID_PRICE:
                    statusLabel.Text = "Status: Invalid price";
                    statusLabel.ForeColor = Color.Red;
                    label2.ForeColor = Color.Red;
                    break;
                case ErrorCodes.INVALID_PUBLISHER:
                    statusLabel.Text = "Status: Invalid publisher";
                    statusLabel.ForeColor = Color.Red;
                    label3.ForeColor = Color.Red;
                    break;
                case ErrorCodes.INVALID_ENTRY5:
                    statusLabel.Text = "Status: Invalid author/director/band/studio";
                    statusLabel.ForeColor = Color.Red;
                    label4.ForeColor = Color.Red;
                    break;
                case ErrorCodes.INVALID_ENTRY6:
                    statusLabel.Text = "Status: Invalid actor/version";
                    statusLabel.ForeColor = Color.Red;
                    label5.ForeColor = Color.Red;
                    break;
                case ErrorCodes.INVALID_REMOVE_TARGET:
                    statusLabel.Text = "Status: Invalid target";
                    statusLabel.ForeColor = Color.Red;
                    label11.ForeColor = Color.Red;
                    break;
                case ErrorCodes.INVALID_ADD_COPIES:
                    statusLabel.Text = "Status: Invalid number of copies";
                    statusLabel.ForeColor = Color.Red;
                    label7.ForeColor = Color.Red;
                    break;
                case ErrorCodes.INVALID_ADD_TARGET:
                    statusLabel.Text = "Status: Invalid target";
                    statusLabel.ForeColor = Color.Red;
                    label6.ForeColor = Color.Red;
                    break;
                case ErrorCodes.INVALID_BUY_COPIES:
                    statusLabelStore.Text = "Status: Invalid number of copies";
                    statusLabelStore.ForeColor = Color.Red;
                    label21.ForeColor = Color.Red;
                    break;
                case ErrorCodes.INVALID_BUY_TARGET:
                    statusLabelStore.Text = "Status: Invalid target";
                    statusLabelStore.ForeColor = Color.Red;
                    label20.ForeColor = Color.Red;
                    break;
                case ErrorCodes.INVALID_PRODUCT_BELOW_ZERO:
                    statusLabelStore.Text = "Status: No more copies of this product";
                    statusLabelStore.ForeColor = Color.Red;
                    break;
                case ErrorCodes.INVALID_OUTOFRANGE:
                    statusLabel.Text = "Status: Only purchases between 0-999 is allowed.";
                    statusLabel.ForeColor = Color.Red;
                    statusLabelStore.Text = "Status: Only purchases between 0-999 is allowed.";
                    statusLabelStore.ForeColor = Color.Red;
                    break;
                case ErrorCodes.SUCCESS:
                    statusLabel.Text = "Status: Operation Successfull";
                    statusLabel.ForeColor = Color.Green;
                    statusLabelStore.Text = "Status: Operation Successfull";
                    statusLabelStore.ForeColor = Color.Green;
                    return true;
            }
            return false;
        }
    }
}
