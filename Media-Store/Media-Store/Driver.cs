﻿using System;
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

        private void SetListeners()
        {
            gui.CreateBook += new EventHandler<StringListEventArgs>(CreateBookEvent);
            gui.CreateMovie += new EventHandler<StringListEventArgs>(CreateMovieEvent);
            gui.CreateCD += new EventHandler<StringListEventArgs>(CreateCDEvent);
            gui.CreateGame += new EventHandler<StringListEventArgs>(CreateGameEvent);
            gui.RemoveProduct += new EventHandler<StringListEventArgs>(RemoveProductEvent);
            gui.OrderMoreProducts += new EventHandler<StringListEventArgs>(OrderMoreProductsEvent);
        }

        private void CreateBookEvent(object obj, StringListEventArgs e)
        {
            inventory.CreateBook(e.str);
            gui.UpdateCurrentInventory(inventory.CurrentProducts);
        }
        private void CreateMovieEvent(object obj, StringListEventArgs e)
        {
            inventory.CreateMovie(e.str);
            gui.UpdateCurrentInventory(inventory.CurrentProducts);
        }
        private void CreateCDEvent(object obj, StringListEventArgs e)
        {
            inventory.CreateCD(e.str);
            gui.UpdateCurrentInventory(inventory.CurrentProducts);
        }

        private void CreateGameEvent(object obj, StringListEventArgs e)
        {
            inventory.CreateGame(e.str);
            gui.UpdateCurrentInventory(inventory.CurrentProducts);
        }
        
        private void RemoveProductEvent(object obj, StringListEventArgs e)
        {
            inventory.RemoveProduct(e.str);
            gui.UpdateCurrentInventory(inventory.CurrentProducts);
        }

        private void OrderMoreProductsEvent(object obj, StringListEventArgs e)
        {
               
        }
    }

    public class StringListEventArgs : EventArgs
    {
        public List<string> str = new List<string>();
    }
}
