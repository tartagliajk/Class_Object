using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klass_och_objekt
{
    internal class Fordon
    {
        public class Car
        {
            public string brand;
            public string model;
            public int year;
            public int horsepower;

            public Car(string brand, string model, int year, int horsepower)
            {
                this.brand = brand;
                this.model = model;
                this.year = year;
                this.horsepower = horsepower;
            }
        }

        public class Motorcycle
        {
            public string brand;
            public string model;
            public int year;

            public Motorcycle(string brand, string model, int year)
            {
                this.brand = brand;
                this.model = model;
                this.year = year;
            }
        }
    }
}
