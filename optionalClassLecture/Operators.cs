using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalClassLecture
{
    internal class Operators
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a+b}");
            Console.ReadKey(); 
        }

        internal void Divide(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine($"{a} / {b} = {a / b}");
            }
            else
            {
                throw new DivideByZeroException(); 
            }
            Console.ReadKey();
        }

        internal void Multiply(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.ReadKey();
        }

        internal void Subract(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.ReadKey();
        }
    }
}
