using System;

namespace Task3Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // PosNeg(4);
            Sum();
            // TruFal();
            Power(2,4);
        }

        static void PosNeg(int number)
        {
            if (number >= 0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }
        }

        static bool TruFal()
        {
            Console.Write("Insert number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool NumCheck = number >= 0;

            Console.WriteLine(NumCheck);
            return NumCheck;
        }

        static void Sum()
        {
            Console.Write("Insert number of variables: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            if (number < 1)
            {
                Console.WriteLine("Cycle not possible");
                return;
            }

            for (int i = 0; i < number; i++)
            {
                Console.Write("Insert number to sum: ");
                int a = Convert.ToInt32(Console.ReadLine());
                sum += a;

            }
            Console.WriteLine("The sum is: " + sum);
        }
    }
        private static int Power(int number, int pow)
        {
            int result = 1;
            
            for(int i = 0; i < pow; i++)
            {
            result *= number;
            }

            return result;
        }
}
