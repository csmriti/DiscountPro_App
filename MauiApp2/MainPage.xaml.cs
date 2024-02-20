﻿using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoadStores();
        }

        private void LoadStores()
        {
            List<string> stores = new List<string>
            {
                "Walmart",
                "Costco",
                "Real Canadian Superstore",
                "Nike",
                "Lululemon"
            };

            storeListView.ItemsSource = stores;
        }
    }
}