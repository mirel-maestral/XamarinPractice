using System;
using System.Collections.Generic;
using TestAppXamarin1.ViewModel;
using Xamarin.Forms;

namespace TestAppXamarin1.Views
{
    public partial class EntryPage : ContentPage
    {
        EntryPageViewModel vm;
        public EntryPage()
        {
            InitializeComponent();
            vm = new EntryPageViewModel();
            BindingContext = vm;
        }

        void addEntry_Clicked(object sender, System.EventArgs e)
        {
            vm.AddToPeople();
            Navigation.PushAsync(new TestAppXamarin1Page());
        }
    }
}
