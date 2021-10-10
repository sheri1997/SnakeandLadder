using System;

namespace Snake_and_Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            int Position = 0;
            Random random = new Random();
            int number = random.Next(0, 6);
            Console.WriteLine("The number at the Dies is " + number);
        }
    }
}
