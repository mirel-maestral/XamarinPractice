using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestAppXamarin1.ViewModel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        private Page2ViewModel vm;
        public Page2()
        {
            InitializeComponent();
            vm = new Page2ViewModel();
            BindingContext = vm;
        }
    }
}
