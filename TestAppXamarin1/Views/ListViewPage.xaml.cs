using System;
using System.Collections.Generic;
using TestAppXamarin1.Models;
using TestAppXamarin1.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestAppXamarin1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();
            BindingContext = new ListViewPageViewModel();
        }

        //void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        //{
        //    if(e.SelectedItem == null)
        //    {
        //        //Handle deselect
        //        return;
        //    }

        //    var person = e.SelectedItem as Person;
        //    DisplayAlert("Selected", $"{person.FirstName} {person.LastName}", "OK");
        //}
    }
}
