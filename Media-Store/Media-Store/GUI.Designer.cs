namespace Media_Store
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.storeTabPage = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusLabelStore = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.buyProductComboBox = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.copiesToBuyTextBox = new System.Windows.Forms.TextBox();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.StockGUI = new System.Windows.Forms.TabPage();
            this.stockLeftPanel = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.stockTabControl = new System.Windows.Forms.TabControl();
            this.addProductTab = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.addProductBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.orderMoreTab = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.orderMoreComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.orderMoreTextBox = new System.Windows.Forms.TextBox();
            this.orderMoreButton = new System.Windows.Forms.Button();
            this.removeProductTab = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.removeProductButton = new System.Windows.Forms.Button();
            this.removeProductBox = new System.Windows.Forms.ComboBox();
            this.addToPurchase = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.resetOrder = new System.Windows.Forms.Button();
            this.dataGridStore = new System.Windows.Forms.DataGridView();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.itemsToBuyListView = new System.Windows.Forms.ListView();
            this.tabControl.SuspendLayout();
            this.storeTabPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.StockGUI.SuspendLayout();
            this.stockLeftPanel.SuspendLayout();
            this.stockTabControl.SuspendLayout();
            this.addProductTab.SuspendLayout();
            this.orderMoreTab.SuspendLayout();
            this.removeProductTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.storeTabPage);
            this.tabControl.Controls.Add(this.StockGUI);
            this.tabControl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(-4, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(938, 553);
            this.tabControl.TabIndex = 0;
            // 
            // storeTabPage
            // 
            this.storeTabPage.Controls.Add(this.tabControl1);
            this.storeTabPage.Controls.Add(this.panel1);
            this.storeTabPage.Location = new System.Drawing.Point(4, 26);
            this.storeTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.storeTabPage.Name = "storeTabPage";
            this.storeTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.storeTabPage.Size = new System.Drawing.Size(930, 523);
            this.storeTabPage.TabIndex = 0;
            this.storeTabPage.Text = "Store";
            this.storeTabPage.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(444, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(483, 515);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage1.Controls.Add(this.dataGridStore);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(475, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current inventory";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(57, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(213, 21);
            this.label19.TabIndex = 31;
            this.label19.Text = "List of all avalible products";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(475, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.itemsToBuyListView);
            this.panel1.Controls.Add(this.resetOrder);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.addToPurchase);
            this.panel1.Controls.Add(this.statusLabelStore);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.buyProductComboBox);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.copiesToBuyTextBox);
            this.panel1.Controls.Add(this.purchaseButton);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 515);
            this.panel1.TabIndex = 0;
            // 
            // statusLabelStore
            // 
            this.statusLabelStore.AutoSize = true;
            this.statusLabelStore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabelStore.Location = new System.Drawing.Point(27, 26);
            this.statusLabelStore.Name = "statusLabelStore";
            this.statusLabelStore.Size = new System.Drawing.Size(204, 21);
            this.statusLabelStore.TabIndex = 42;
            this.statusLabelStore.Text = "Status: Nothing done yet";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(28, 147);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 17);
            this.label20.TabIndex = 41;
            this.label20.Text = "Select product";
            // 
            // buyProductComboBox
            // 
            this.buyProductComboBox.FormattingEnabled = true;
            this.buyProductComboBox.Location = new System.Drawing.Point(143, 144);
            this.buyProductComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buyProductComboBox.Name = "buyProductComboBox";
            this.buyProductComboBox.Size = new System.Drawing.Size(180, 25);
            this.buyProductComboBox.TabIndex = 38;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(28, 197);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(159, 17);
            this.label21.TabIndex = 40;
            this.label21.Text = "How many copies to buy?";
            // 
            // copiesToBuyTextBox
            // 
            this.copiesToBuyTextBox.Location = new System.Drawing.Point(207, 192);
            this.copiesToBuyTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.copiesToBuyTextBox.Name = "copiesToBuyTextBox";
            this.copiesToBuyTextBox.Size = new System.Drawing.Size(116, 22);
            this.copiesToBuyTextBox.TabIndex = 39;
            // 
            // purchaseButton
            // 
            this.purchaseButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.purchaseButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.purchaseButton.FlatAppearance.BorderSize = 5;
            this.purchaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.purchaseButton.Location = new System.Drawing.Point(157, 455);
            this.purchaseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(261, 48);
            this.purchaseButton.TabIndex = 34;
            this.purchaseButton.Text = "Confirm Purchase";
            this.purchaseButton.UseVisualStyleBackColor = false;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(27, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 21);
            this.label18.TabIndex = 0;
            this.label18.Text = "Do a purchase";
            // 
            // StockGUI
            // 
            this.StockGUI.Controls.Add(this.stockLeftPanel);
            this.StockGUI.Controls.Add(this.stockTabControl);
            this.StockGUI.Location = new System.Drawing.Point(4, 26);
            this.StockGUI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StockGUI.Name = "StockGUI";
            this.StockGUI.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StockGUI.Size = new System.Drawing.Size(930, 523);
            this.StockGUI.TabIndex = 1;
            this.StockGUI.Text = "Inventory";
            this.StockGUI.UseVisualStyleBackColor = true;
            // 
            // stockLeftPanel
            // 
            this.stockLeftPanel.BackColor = System.Drawing.Color.Aquamarine;
            this.stockLeftPanel.Controls.Add(this.dataGridViewInventory);
            this.stockLeftPanel.Controls.Add(this.statusLabel);
            this.stockLeftPanel.Controls.Add(this.label12);
            this.stockLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.stockLeftPanel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLeftPanel.Location = new System.Drawing.Point(3, 4);
            this.stockLeftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stockLeftPanel.Name = "stockLeftPanel";
            this.stockLeftPanel.Size = new System.Drawing.Size(434, 515);
            this.stockLeftPanel.TabIndex = 38;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(19, 13);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(208, 21);
            this.statusLabel.TabIndex = 36;
            this.statusLabel.Text = "Status:  Nothing done yet";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(213, 21);
            this.label12.TabIndex = 29;
            this.label12.Text = "List of all avalible products";
            // 
            // stockTabControl
            // 
            this.stockTabControl.Controls.Add(this.addProductTab);
            this.stockTabControl.Controls.Add(this.orderMoreTab);
            this.stockTabControl.Controls.Add(this.removeProductTab);
            this.stockTabControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.stockTabControl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockTabControl.Location = new System.Drawing.Point(442, 4);
            this.stockTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stockTabControl.Name = "stockTabControl";
            this.stockTabControl.SelectedIndex = 0;
            this.stockTabControl.Size = new System.Drawing.Size(485, 515);
            this.stockTabControl.TabIndex = 37;
            // 
            // addProductTab
            // 
            this.addProductTab.BackColor = System.Drawing.Color.SkyBlue;
            this.addProductTab.Controls.Add(this.label9);
            this.addProductTab.Controls.Add(this.label8);
            this.addProductTab.Controls.Add(this.addProductButton);
            this.addProductTab.Controls.Add(this.headerLabel);
            this.addProductTab.Controls.Add(this.addProductBox);
            this.addProductTab.Controls.Add(this.textBox1);
            this.addProductTab.Controls.Add(this.textBox2);
            this.addProductTab.Controls.Add(this.textBox3);
            this.addProductTab.Controls.Add(this.textBox4);
            this.addProductTab.Controls.Add(this.textBox5);
            this.addProductTab.Controls.Add(this.textBox6);
            this.addProductTab.Controls.Add(this.label1);
            this.addProductTab.Controls.Add(this.label10);
            this.addProductTab.Controls.Add(this.label2);
            this.addProductTab.Controls.Add(this.label5);
            this.addProductTab.Controls.Add(this.label3);
            this.addProductTab.Controls.Add(this.label4);
            this.addProductTab.Location = new System.Drawing.Point(4, 26);
            this.addProductTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addProductTab.Name = "addProductTab";
            this.addProductTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addProductTab.Size = new System.Drawing.Size(477, 485);
            this.addProductTab.TabIndex = 0;
            this.addProductTab.Text = "Add product";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Select product type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(319, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "To add a new product please fill out the form below. ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.SteelBlue;
            this.addProductButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addProductButton.FlatAppearance.BorderSize = 5;
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addProductButton.Location = new System.Drawing.Point(28, 374);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(428, 48);
            this.addProductButton.TabIndex = 0;
            this.addProductButton.Text = "Add new product";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(24, 16);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(151, 21);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "Add new product";
            // 
            // addProductBox
            // 
            this.addProductBox.BackColor = System.Drawing.SystemColors.Window;
            this.addProductBox.FormattingEnabled = true;
            this.addProductBox.Location = new System.Drawing.Point(163, 111);
            this.addProductBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addProductBox.Name = "addProductBox";
            this.addProductBox.Size = new System.Drawing.Size(191, 25);
            this.addProductBox.TabIndex = 4;
            this.addProductBox.SelectedIndexChanged += new System.EventHandler(this.addProductBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 160);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 193);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(163, 225);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(163, 262);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(163, 294);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(116, 22);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(163, 326);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(116, 22);
            this.textBox6.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Product name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Unique identifier:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Price of product:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Book version:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Product publisher:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Book author:";
            // 
            // orderMoreTab
            // 
            this.orderMoreTab.BackColor = System.Drawing.Color.SkyBlue;
            this.orderMoreTab.Controls.Add(this.label14);
            this.orderMoreTab.Controls.Add(this.label13);
            this.orderMoreTab.Controls.Add(this.label6);
            this.orderMoreTab.Controls.Add(this.orderMoreComboBox);
            this.orderMoreTab.Controls.Add(this.label7);
            this.orderMoreTab.Controls.Add(this.orderMoreTextBox);
            this.orderMoreTab.Controls.Add(this.orderMoreButton);
            this.orderMoreTab.Location = new System.Drawing.Point(4, 26);
            this.orderMoreTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderMoreTab.Name = "orderMoreTab";
            this.orderMoreTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderMoreTab.Size = new System.Drawing.Size(477, 485);
            this.orderMoreTab.TabIndex = 1;
            this.orderMoreTab.Text = "Order products";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "Select product";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(325, 17);
            this.label13.TabIndex = 36;
            this.label13.Text = "Order more copies of a specific product from retailer.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "Order copies";
            // 
            // orderMoreComboBox
            // 
            this.orderMoreComboBox.FormattingEnabled = true;
            this.orderMoreComboBox.Location = new System.Drawing.Point(162, 129);
            this.orderMoreComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderMoreComboBox.Name = "orderMoreComboBox";
            this.orderMoreComboBox.Size = new System.Drawing.Size(180, 25);
            this.orderMoreComboBox.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "How many copies to buy?";
            // 
            // orderMoreTextBox
            // 
            this.orderMoreTextBox.Location = new System.Drawing.Point(226, 177);
            this.orderMoreTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderMoreTextBox.Name = "orderMoreTextBox";
            this.orderMoreTextBox.Size = new System.Drawing.Size(116, 22);
            this.orderMoreTextBox.TabIndex = 33;
            // 
            // orderMoreButton
            // 
            this.orderMoreButton.BackColor = System.Drawing.Color.SteelBlue;
            this.orderMoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.orderMoreButton.FlatAppearance.BorderSize = 5;
            this.orderMoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.orderMoreButton.Location = new System.Drawing.Point(50, 246);
            this.orderMoreButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderMoreButton.Name = "orderMoreButton";
            this.orderMoreButton.Size = new System.Drawing.Size(256, 48);
            this.orderMoreButton.TabIndex = 34;
            this.orderMoreButton.Text = "Order more copies";
            this.orderMoreButton.UseVisualStyleBackColor = false;
            this.orderMoreButton.Click += new System.EventHandler(this.orderMoreButton_Click);
            // 
            // removeProductTab
            // 
            this.removeProductTab.BackColor = System.Drawing.Color.SkyBlue;
            this.removeProductTab.Controls.Add(this.label17);
            this.removeProductTab.Controls.Add(this.label16);
            this.removeProductTab.Controls.Add(this.label15);
            this.removeProductTab.Controls.Add(this.label11);
            this.removeProductTab.Controls.Add(this.removeProductButton);
            this.removeProductTab.Controls.Add(this.removeProductBox);
            this.removeProductTab.Location = new System.Drawing.Point(4, 26);
            this.removeProductTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeProductTab.Name = "removeProductTab";
            this.removeProductTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeProductTab.Size = new System.Drawing.Size(477, 485);
            this.removeProductTab.TabIndex = 2;
            this.removeProductTab.Text = "Remove products";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(40, 161);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(178, 17);
            this.label17.TabIndex = 31;
            this.label17.Text = "Select a product to remove:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(40, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(241, 17);
            this.label16.TabIndex = 30;
            this.label16.Text = "this will delete the entire product entry.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(208, 17);
            this.label15.TabIndex = 29;
            this.label15.Text = "Remove a product from the stock";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 21);
            this.label11.TabIndex = 28;
            this.label11.Text = "Remove a product";
            // 
            // removeProductButton
            // 
            this.removeProductButton.BackColor = System.Drawing.Color.SteelBlue;
            this.removeProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeProductButton.Location = new System.Drawing.Point(43, 249);
            this.removeProductButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeProductButton.Name = "removeProductButton";
            this.removeProductButton.Size = new System.Drawing.Size(271, 48);
            this.removeProductButton.TabIndex = 1;
            this.removeProductButton.Text = "Remove product from inventory";
            this.removeProductButton.UseVisualStyleBackColor = false;
            this.removeProductButton.Click += new System.EventHandler(this.removeProductButton_Click);
            // 
            // removeProductBox
            // 
            this.removeProductBox.FormattingEnabled = true;
            this.removeProductBox.Location = new System.Drawing.Point(224, 158);
            this.removeProductBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeProductBox.Name = "removeProductBox";
            this.removeProductBox.Size = new System.Drawing.Size(140, 25);
            this.removeProductBox.TabIndex = 5;
            // 
            // addToPurchase
            // 
            this.addToPurchase.BackColor = System.Drawing.Color.LightSeaGreen;
            this.addToPurchase.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addToPurchase.FlatAppearance.BorderSize = 5;
            this.addToPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addToPurchase.Location = new System.Drawing.Point(210, 225);
            this.addToPurchase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addToPurchase.Name = "addToPurchase";
            this.addToPurchase.Size = new System.Drawing.Size(155, 48);
            this.addToPurchase.TabIndex = 43;
            this.addToPurchase.Text = "Add to purchase order";
            this.addToPurchase.UseVisualStyleBackColor = false;
            this.addToPurchase.Click += new System.EventHandler(this.addToPurchase_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(28, 241);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(176, 17);
            this.label22.TabIndex = 44;
            this.label22.Text = "Your current purchase order:";
            // 
            // resetOrder
            // 
            this.resetOrder.BackColor = System.Drawing.Color.LightSeaGreen;
            this.resetOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.resetOrder.FlatAppearance.BorderSize = 5;
            this.resetOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetOrder.Location = new System.Drawing.Point(31, 455);
            this.resetOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resetOrder.Name = "resetOrder";
            this.resetOrder.Size = new System.Drawing.Size(120, 48);
            this.resetOrder.TabIndex = 45;
            this.resetOrder.Text = "Reset order";
            this.resetOrder.UseVisualStyleBackColor = false;
            this.resetOrder.Click += new System.EventHandler(this.resetOrder_Click);
            // 
            // dataGridStore
            // 
            this.dataGridStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStore.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridStore.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridStore.Location = new System.Drawing.Point(27, 118);
            this.dataGridStore.Name = "dataGridStore";
            this.dataGridStore.ReadOnly = true;
            this.dataGridStore.RowTemplate.Height = 20;
            this.dataGridStore.Size = new System.Drawing.Size(422, 324);
            this.dataGridStore.TabIndex = 33;
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Location = new System.Drawing.Point(6, 95);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.ReadOnly = true;
            this.dataGridViewInventory.Size = new System.Drawing.Size(414, 409);
            this.dataGridViewInventory.TabIndex = 37;
            // 
            // itemsToBuyListView
            // 
            this.itemsToBuyListView.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsToBuyListView.Location = new System.Drawing.Point(31, 281);
            this.itemsToBuyListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.itemsToBuyListView.Name = "itemsToBuyListView";
            this.itemsToBuyListView.Size = new System.Drawing.Size(387, 166);
            this.itemsToBuyListView.TabIndex = 34;
            this.itemsToBuyListView.TileSize = new System.Drawing.Size(1, 1);
            this.itemsToBuyListView.UseCompatibleStateImageBehavior = false;
            this.itemsToBuyListView.View = System.Windows.Forms.View.List;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(927, 546);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GUI";
            this.Text = "Media Store";
            this.tabControl.ResumeLayout(false);
            this.storeTabPage.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.StockGUI.ResumeLayout(false);
            this.stockLeftPanel.ResumeLayout(false);
            this.stockLeftPanel.PerformLayout();
            this.stockTabControl.ResumeLayout(false);
            this.addProductTab.ResumeLayout(false);
            this.addProductTab.PerformLayout();
            this.orderMoreTab.ResumeLayout(false);
            this.orderMoreTab.PerformLayout();
            this.removeProductTab.ResumeLayout(false);
            this.removeProductTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage storeTabPage;
        private System.Windows.Forms.TabPage StockGUI;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button removeProductButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.ComboBox removeProductBox;
        private System.Windows.Forms.ComboBox addProductBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button orderMoreButton;
        private System.Windows.Forms.TextBox orderMoreTextBox;
        private System.Windows.Forms.ComboBox orderMoreComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl stockTabControl;
        private System.Windows.Forms.TabPage addProductTab;
        private System.Windows.Forms.TabPage orderMoreTab;
        private System.Windows.Forms.TabPage removeProductTab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel stockLeftPanel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox buyProductComboBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox copiesToBuyTextBox;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label statusLabelStore;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button addToPurchase;
        private System.Windows.Forms.Button resetOrder;
        private System.Windows.Forms.DataGridView dataGridStore;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.ListView itemsToBuyListView;
    }
}

