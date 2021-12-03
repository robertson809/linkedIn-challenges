using System;

namespace Challenge2_Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your passcode");
            var password_response = Console.ReadLine();

            if (password_response == "secret")
            {
                Console.WriteLine("You have been authenticated.");
            }
            else
            {
                Console.WriteLine("Incorrect Password");
            }
        }
    }
}
