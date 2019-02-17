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
        }

        private void addProductBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            ClearCurrentWindow();
        }

        private void removeProductButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearCurrentWindow()
        {
            this.tabControl.SelectedTab.Controls.Clear();
        }
    }
}
