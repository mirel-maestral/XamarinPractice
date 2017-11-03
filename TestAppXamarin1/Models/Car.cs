using System;
using TestAppXamarin1.Data;

namespace TestAppXamarin1.Models
{
    public class Car: IEntity
    {
        public string Name
        {
            get;
            set;
        }

        public int ID
        {
            get;
            set;
        }
        public Car()
        {
        }
    }
}
