using System;
using System.Collections.Generic;
using ListViewGroup.ViewModels;
using Xamarin.Forms;

namespace ListViewGroup.Views
{
    public partial class CarsPage : ContentPage
    {
        public CarsPage()
        {
            InitializeComponent();
            BindingContext = new CarsViewModel();
        }
    }
}
