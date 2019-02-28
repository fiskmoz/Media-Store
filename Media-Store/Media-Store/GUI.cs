using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        public event EventHandler<StringListEventArgs> BuyProductCheck;
        public event EventHandler<ProductListEventArgs> BuyProducts;
        public event EventHandler<StringListEventArgs> SearchProduct;

        private GUIHelper helper;

        private Order order;
        private List<ComboBox> comboBoxes;

        public DataGridView dataGridStoreP;

        public GUI()
        {
            InitializeComponent();
            order = new Order();
            helper = new GUIHelper(this);
            dataGridStoreP = this.dataGridStore;
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
            var args = new ProductListEventArgs();
            if (order.list.Count < 1)
                return;
            args.products = order.list;
            args.ToBuy = order.ToBuy;
            BuyProducts(this, args);
            if (receiptCheckBox.Checked)
                helper.PrintDoc();
        }

        private void addToPurchase_Click(object sender, EventArgs e)
        {
            var args = new StringListEventArgs();
            args.str.Add((string)buyProductComboBox.SelectedItem);
            var totalPrice = 0;
            foreach (var price in order.ToBuy)
                totalPrice += price;
            args.str.Add(copiesToBuyTextBox.Text);
            args.str.Add(totalPrice.ToString());
            BuyProductCheck(this, args);
        }

        public void resetOrder_Click(object sender, EventArgs e)
        {
            order.list.Clear();
            order.ToBuy.Clear();
            itemsToBuyListView.Items.Clear();
            itemsToBuyListView.Items.Add(string.Format("{0,-20}{1,-20}", "ID", "CopiesToBuy"));
        }

        private void returnTheProductButton_Click(object sender, EventArgs e)
        {
            var args = new StringListEventArgs();
            args.str.Add((string)rebuyComboBox.SelectedItem);
            args.str.Add("1");
            OrderMoreProducts(this, args);
        }

        private void searchButtonStore_Click(object sender, EventArgs e)
        {
            var args = new StringListEventArgs();
            args.str.Add(searchBoxStore.Text);
            SearchProduct(this, args);
        }

        private void searchButtonInventory_Click(object sender, EventArgs e)
        {
            var args = new StringListEventArgs();
            args.str.Add(searchBoxInventory.Text);
            SearchProduct(this, args);
        }

        internal void UpdateSearchFindings(List<Product> list)
        {
            searchViewInventory.Clear();
            searchViewStore.Clear();
            searchViewInventory.Items.Add(string.Format("{0,-20}{1,-20}{2,-20}", "ID", "Name", "Publisher"));
            searchViewStore.Items.Add(string.Format("{0,-20}{1,-20}{2,-20}", "ID", "Name", "Publisher"));
            foreach (var elem in list)
            {
                searchViewInventory.Items.Add(string.Format("{0,-20}{1,-20}{2,-20}",elem.uniqueID, elem.name, elem.publisher));
                searchViewStore.Items.Add(string.Format("{0,-20}{1,-20}{2,-20}", elem.uniqueID, elem.name, elem.publisher));
            }
        }

        internal void CreateNewSetSelection(List<Product> list)
        {
            foreach(var elem in list)
            {
                addProductBox.Items.Add(elem.GetType().ToString().Replace("Media_Store.", ""));
            }
            addProductBox.SelectedIndex = 0;
            comboBoxes = new List<ComboBox>();
            comboBoxes.Add(removeProductBox);
            comboBoxes.Add(orderMoreComboBox);
            comboBoxes.Add(buyProductComboBox);
            comboBoxes.Add(rebuyComboBox);
            itemsToBuyListView.Items.Add(string.Format("{0,-20}{1,-20}", "ID", "CopiesToBuy"));

        }

        internal bool DisplayTextBox()
        {
            return helper.DisplayRemoveAlert();
        }

        internal void UpdateCurrentInventory(List<Product> list)
        {
            foreach (var box in comboBoxes)
                box.Items.Clear();
            DataTable table = helper.CreateTable(list);
            dataGridStore.DataSource = table;
            dataGridViewInventory.DataSource = table;
            foreach (Product pro in list)
            {
                foreach (var box in comboBoxes)
                    box.Items.Add(pro.uniqueID);
            }
            foreach(var box in comboBoxes)
            {
                if (box.Items.Count > 0)
                    box.SelectedIndex = 0;
            }
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

        internal void UpdateOrderList(Product prod)
        {
            itemsToBuyListView.Items.Add(string.Format("{0,-20}{1,-20}", (string)buyProductComboBox.SelectedItem, copiesToBuyTextBox.Text));
            order.list.Add(prod);
            order.ToBuy.Add(Int32.Parse(copiesToBuyTextBox.Text));
        }
    }
}
