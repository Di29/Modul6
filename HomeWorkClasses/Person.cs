using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClasses
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Nationality { get; set; }

        public int Age { get; set; }

        public double Weight { get; set; }

        public Person(string fName, string lName, string nationality, int age, double weight)
        {
            FirstName = fName;
            LastName = lName;
            Nationality = nationality;
            Age = age;
            Weight = weight;
        }
    }
}
