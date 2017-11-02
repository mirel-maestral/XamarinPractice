using System;
using TestAppXamarin1.Models;

namespace TestAppXamarin1.ViewModel
{
    public class EntryPageViewModel
    {
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
       
        }

        public string PhoneNumber
        {
            get;
            set;
        }

        public EntryPageViewModel()
        {
        }

        public void AddToPeople()
        {
            Person person = new Person();
            person.FirstName = this.FirstName;
            person.LastName = this.LastName;
            person.PhoneNumber = this.PhoneNumber;
            //Person.People.Add(person);

            App.Database.SavePersonAsync(person);
        }
    }
}
