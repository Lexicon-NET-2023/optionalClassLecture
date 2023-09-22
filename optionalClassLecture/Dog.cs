using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalClassLecture
{
    internal class Dog : Animal
    {
        public Dog(string name, string color) : base(name, color)
        {
            Name = name;
            Color = color;
        }

        //public string Color { get; set; }
        public override void Speak()
        {
            Console.WriteLine($"{Name} says woof!");
        }
    }
}
