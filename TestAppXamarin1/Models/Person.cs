using System;
using System.Collections.Generic;

using System.Linq;
using SQLite;

namespace TestAppXamarin1.Models
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int ID
        {
            get;
            set;
        }
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
        public string Address
        {
            get;
            set;
        }

        public string ImageSource
        {
            get;
            set;
        }
        public decimal Age { get; set; }

        public string PhoneNumber
        {
            get;
            set;
        }

        //public static List<Person> People = new List<Person>(); 

        public Person()
        {
        }
    }
}
