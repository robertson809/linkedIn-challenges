using System;

namespace Challenge3_LoopCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=5; i ++)
            {
                Console.WriteLine("Counting up and down for the {0} time", i);
                for (int superman = 1; superman <=10; superman ++)
                {
                    Console.WriteLine(superman);
                }
                
                for (int j = 9; j >=1; j--)
                {
                    Console.WriteLine(j);
                }
                
            }
        }
    }
}
