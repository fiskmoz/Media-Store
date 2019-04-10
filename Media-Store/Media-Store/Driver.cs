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
            inventory = new Inventory();
            gui.CreateNewSetSelection(inventory.ProductSelection);
            gui.UpdateCurrentInventory(inventory.CurrentProducts);
            SetListeners();
            
            Application.Run(gui);
        }

        // Setting up listeners for events in the prgram and then decide the flow of the program depending on what events fire.
        private void SetListeners()
        {
            gui.CreateBook += new EventHandler<StringListEventArgs>(CreateBookEvent);
            gui.CreateMovie += new EventHandler<StringListEventArgs>(CreateMovieEvent);
            gui.CreateCD += new EventHandler<StringListEventArgs>(CreateCDEvent);
            gui.CreateGame += new EventHandler<StringListEventArgs>(CreateGameEvent);
            gui.RemoveProduct += new EventHandler<StringListEventArgs>(RemoveProductEvent);
            gui.OrderMoreProducts += new EventHandler<StringListEventArgs>(OrderMoreProductsEvent);
            gui.BuyProductCheck += new EventHandler<StringListEventArgs>(BuyProductsCheck);
            gui.BuyProducts += new EventHandler<ProductListEventArgs>(BuyProducts);
            gui.SearchProduct += new EventHandler<StringListEventArgs>(SearchProducts);
        }

        private void CreateBookEvent(object obj, StringListEventArgs e)
        {
            if(gui.UpdateSuccessLabel(inventory.CreateProduct("Book", e.str)))
                gui.UpdateCurrentInventory(inventory.CurrentProducts);
        }
        private void CreateMovieEvent(object obj, StringListEventArgs e)
        {
            if(gui.UpdateSuccessLabel(inventory.CreateProduct("Movie",e.str)))
                gui.UpdateCurrentInventory(inventory.CurrentProducts);
        }
        private void CreateCDEvent(object obj, StringListEventArgs e)
        {
            if(gui.UpdateSuccessLabel(inventory.CreateProduct("CD", e.str)))
                gui.UpdateCurrentInventory(inventory.CurrentProducts);
        }

        private void CreateGameEvent(object obj, StringListEventArgs e)
        {
            if(gui.UpdateSuccessLabel(inventory.CreateProduct("Game", e.str)))
                gui.UpdateCurrentInventory(inventory.CurrentProducts);
        }
        
        private void RemoveProductEvent(object obj, StringListEventArgs e)
        {
            if (inventory.GetCopies(e.str[0]) > 0)
                if (!gui.DisplayTextBox())
                    return;
            if(gui.UpdateSuccessLabel(inventory.RemoveProduct(e.str)))
                gui.UpdateCurrentInventory(inventory.CurrentProducts);
        }

        private void OrderMoreProductsEvent(object obj, StringListEventArgs e)
        {
            if(gui.UpdateSuccessLabel(inventory.OrderMoreProducts(e.str)))
                gui.UpdateCurrentInventory(inventory.CurrentProducts);
        }

        private void BuyProductsCheck(object obj, StringListEventArgs e)
        {
            if (gui.UpdateSuccessLabel(inventory.BuyProductCheck(e.str)))
                gui.UpdateOrderList(inventory.GetProduct(e.str[0]));
        }

        private void BuyProducts(object obj, ProductListEventArgs e)
        {
            if (gui.UpdateSuccessLabel(inventory.BuyProducts(e.products, e.ToBuy)))
            {
                gui.UpdateCurrentInventory(inventory.CurrentProducts);
                gui.resetOrder_Click(this, new EventArgs());
            }
        }

        private void SearchProducts(object obj, StringListEventArgs e)
        {
            gui.UpdateSearchFindings(inventory.GetProducts(e.str[0]));
        }
    }
}
