using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Teacher : Person
    {
        public Teacher(string name, string surname, byte age) : base(name,surname,age)
        {
            
        }

        public void Explain() 
        {
            Console.WriteLine("Explaining...");
        }
    }
}
