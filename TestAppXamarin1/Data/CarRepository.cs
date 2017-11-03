using System;
using TestAppXamarin1.Models;

namespace TestAppXamarin1.Data
{
    public class CarRepository: GenericFileRepository<Car>
    {
        public CarRepository() : base("CarFile.Json")
        {
        }
    }
}
