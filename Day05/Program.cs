using System;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose one - sum, sub, time, div: ");
            String choice = Console.ReadLine();

            Console.Write("Choose number: ");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Choose number: ");
            double b = Convert.ToInt32(Console.ReadLine());

            if(choice == "sum")
            {
                Console.WriteLine(Calculator.Sum(a, b));
            }
            else if(choice == "sub")
            {
                Console.WriteLine(Calculator.Sub(a, b));
            }
            else if (choice == "div")
            {
                Console.WriteLine(Calculator.Div(a, b));
            }
            else if (choice == "time")
            {
                Console.WriteLine(Calculator.Time(a, b));
            }
        }
    }
}
