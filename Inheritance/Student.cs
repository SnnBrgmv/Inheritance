using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Student : Person
    {
        public Student(string name,string surname,byte age) : base(name, surname, age)
        {
            
        }

        public void Learn() 
        {
            Console.WriteLine("Learning...");
        }
    }
}
