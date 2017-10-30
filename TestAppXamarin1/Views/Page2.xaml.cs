using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestAppXamarin1.ViewModel
{
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
