using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalClassLecture
{
    internal class Animal
    {
        public Animal(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public string Name { get; set; }
        public string Color { get; set; }

        //Kommer int åt private
        private int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public virtual void Speak()
        {
            Console.WriteLine("[Insert animal sound here]");
        }

    }
}
