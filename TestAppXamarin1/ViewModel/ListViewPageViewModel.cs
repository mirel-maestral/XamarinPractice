using System;
using System.Collections.ObjectModel;
using TestAppXamarin1.Models;

namespace TestAppXamarin1.ViewModel
{
    public class ListViewPageViewModel
    {
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();
        public ListViewPageViewModel()
        {
            Random rnd = new Random();
            for (int i = 1; i < 6; i++)
            {
                this.People.Add(new Person()
                {
                    FirstName = String.Format("{0} {1}", "Mirel", i.ToString()),
                    //LastName = String.Format("{0} {1}", "Spahic", i.ToString()),
                    //Address = $"{i.ToString()} address",
                    //ImageSource = $"man{i.ToString()}.jpeg"
                    Age = (decimal)(35 + rnd.NextDouble())
                });
            }
        }
    }
}
