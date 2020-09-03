using System;
using System.Globalization;

namespace Day_01
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                PosNeg();
            }
            static void PosNeg()
            {
                Console.Write("Insert number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number >= 0)
                {
                    Console.WriteLine("number is positive");
                }
                else
                {
                    Console.WriteLine("number is negative");
                }
            }

        {
            Task01();
        }

            static void Task01()
            {
                // Task 01

                Console.Write("Insert number: ");
                String input = Console.ReadLine();

                int number = 0;

                try
                {
                    number = Convert.ToInt32(input);

                }
                catch
                {
                    Console.Write("Wrong!");
                }

                if (number > 5)
                {
                    Console.WriteLine("Number input: " + number + " is: **");
                }
                else if (number < 5)
                {
                    Console.WriteLine("Number input: " + number + " is: *");
                }
                else
                {
                    Console.WriteLine("Number input: " + number + " is: Even");
                }
                Console.WriteLine();
            }

            {
                Task02();
            }

            static void Task02()
            {
                // Task 02

                int sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Insert number: ");
                    String input = Console.ReadLine();
                    int number = Convert.ToInt32(input);
                    sum += number;
                }
                Console.WriteLine("Total sum = " + sum);
                Console.WriteLine();
            }

            static void Sample()
            {
                Console.WriteLine("Insert number!: ");
                String input = Console.ReadLine(); // User input in console (Only inputs as a string) acts like Scanner in Java


                String ex = "Hello ";

                int numbers = 0;
                try
                {
                    numbers = Convert.ToInt32(input); // Converts String "input" to Int

                }
                catch
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine(ex + "World!");
                Console.WriteLine("Reinis! " + numbers);


                for (int i = 0; i < 10; i++)
                {

                }
            } // Void method does a thing, other needs alues to be returned


            static int Sample2()
            {

                return 5 + 4; // int method needs to have a retrun value
            }


            // Next Task 03 / Homework


        }


    }
}
