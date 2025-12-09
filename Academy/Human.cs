using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Human
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }

        public Human(string lastName,string firstName, int age)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            Console.WriteLine($"HCostructor: {GetHashCode()}");
        }

        ~Human()
        {
            Console.WriteLine($"HDestructor: {GetHashCode()}");
        }
        public void info()
        {
            Console.WriteLine($"LastName:{LastName}\tFirstName:{FirstName}\tAge:{Age}");
        }
    }
}
