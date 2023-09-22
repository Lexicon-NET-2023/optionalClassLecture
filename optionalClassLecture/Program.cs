using System.ComponentModel;
using System.Globalization;

namespace optionalClassLecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operators op = new Operators(); 
            //bool isAlive = true;
            //while (isAlive)
            //{
            //    try
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Welcome to Krallculator 3000! \n" +
            //            "Please select your numbers followed by one of the following operators: \n" +
            //            "+: Add\n" +
            //            "-: Subtract\n" +
            //            "*: Multiply\n" +
            //            "/: Divide\n" +
            //            "Q: Quit");

            //        Console.Write("Please choose your first number: ");
            //        int a = Convert.ToInt32(Console.ReadLine());
            //        Console.Write("Please choose your second number: ");
            //        int b = Convert.ToInt32(Console.ReadLine());
            //        Console.Write("Select your operator (+ - * /): ");
            //        ConsoleKey selection = Console.ReadKey().Key;

            //        Console.WriteLine();

            //        switch (selection)
            //        {
            //            case ConsoleKey.Add:
            //                op.Add(a, b);
            //                break;
            //            case ConsoleKey.Subtract:
            //                op.Subract(a, b);
            //                break;
            //            case ConsoleKey.Multiply:
            //                op.Multiply(a, b);
            //                break;
            //            case ConsoleKey.Divide:
            //                op.Divide(a, b);
            //                break;
            //            case ConsoleKey.Q:
            //                Console.WriteLine("Thank you for using my Krallculator 3000!");
            //                isAlive = false;
            //                //Environment.Exit(0);
            //                break;
            //            default:
            //                Console.WriteLine("Not a valid choice");
            //                Console.ReadKey();
            //                break;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        Console.ReadKey();
            //    }
            //    //catch(DivideByZeroException)
            //    //{
            //    //    throw; 
            //    //}

            //}

            Dog dog = new Dog("Steve", "Black");
            dog.Eat();
            dog.Speak(); 
            Cat cat = new Cat("Sprig", "White");
            cat.Speak();
            //Animal animal = new Animal();
           
            Console.ReadKey(); 
        }
    }
}