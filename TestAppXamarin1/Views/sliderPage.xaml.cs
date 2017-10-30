using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestAppXamarin1.ViewModel
{
    public partial class sliderPage : ContentPage
    {
        public sliderPage()
        {
            InitializeComponent();
            BindingContext = new SliderPageViewModel();
        }
    }
}
