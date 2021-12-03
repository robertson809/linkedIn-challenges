using System;

namespace Challenge1_MCQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();
            Console.WriteLine("What month were you born in?");
            var birth_month = Console.ReadLine();

            Console.WriteLine("Printing Results...");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Birth Month:" + birth_month);


        }
    }
}
