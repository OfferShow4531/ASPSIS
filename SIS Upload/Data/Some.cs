using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIS_Upload.Data
{
    public class Some
    {
     public abstract class Person 
        { 
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine(Name);
        }
    }
    class Client : Person
    {
        public int Sum { get; set; }    // сумма на счету

        public Client(string name, int sum)
            : base(name)
        {
            Sum = sum;
        }
    }
    class Employee : Person
    {
        public string Position { get; set; } // должность

        public Employee(string name, string position)
            : base(name)
        {
            Position = position;
        }
    }
}
}
