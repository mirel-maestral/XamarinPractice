using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestAppXamarin1.ViewModel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class sliderPage : ContentPage
    {
        public sliderPage()
        {
            InitializeComponent();
            BindingContext = new SliderPageViewModel();
        }
    }
}
