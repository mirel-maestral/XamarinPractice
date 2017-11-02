using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TestAppXamarin1.Models;
using Xamarin.Forms;

namespace TestAppXamarin1.ViewModel
{
    public class ListViewPageViewModel: INotifyPropertyChanged
    {
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();
        public ICommand ItemSelectedCommand { get; private set; }
        private string selectedItemText;

        public event PropertyChangedEventHandler PropertyChanged;

        public string SelecedItemText
        {
            get
            {
                return selectedItemText;

            }
            set
            {
                selectedItemText = value;
                RaisePropertyChanged();
            }
        }

        protected void RaisePropertyChanged([CallerMemberName]string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

        public ListViewPageViewModel()
        {
            //Random rnd = new Random();
            //for (int i = 1; i < 6; i++)
            //{
            //    this.People.Add(new Person()
            //    {
            //        FirstName = String.Format("{0} {1}", "Mirel", i.ToString()),
            //        //LastName = String.Format("{0} {1}", "Spahic", i.ToString()),
            //        //Address = $"{i.ToString()} address",
            //        //ImageSource = $"man{i.ToString()}.jpeg"
            //        Age = (decimal)(35 + rnd.NextDouble())
            //    });
            //}

            //foreach(var person in Person.People)
            //{
            //    this.People.Add(new Person()
            //    {
            //        LastName = person.LastName,
            //        FirstName = person.FirstName,
            //        PhoneNumber = person.PhoneNumber
            //    });
            //}

            PopulatePeople();

            ItemSelectedCommand = new Command<Person>(HandleItemSelected);
        }
        private async void PopulatePeople(){
            var people = await App.Database.GetPeopleAsync();
            foreach(var p in people)
            {
                People.Add(p);
            }
        }
        private void HandleItemSelected(Person person)
        {
            this.SelecedItemText = $"{person.FirstName} {person.LastName}";
        }
    }
}
