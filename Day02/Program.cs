using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;

namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            // RandomSample();
            // RandomSampleInput();
            // Arrange();
            // ArraySample();
            ArrInput();
        }
        static void RandomSample() // How to generate random numbers
        {
            Random random = new Random();

            int numbers = 0;
            for (int i = 0; i < 10; i++)
            {
                int r = random.Next(10, 60);

                Console.WriteLine("Random numbers: " + r);

                if(numbers < r)
                {
                    numbers = r;
                }
            }
            Console.WriteLine("Highest number: " + numbers);
        }
        static void RandomSampleInput()
        {
            // Random random = new Random();
            long numbers = int.MinValue; // Sets the minimum value to be the input and not 0
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Insert random numbers: ");
                int r = Convert.ToInt32(Console.ReadLine());

                if (numbers < r)
                {
                    numbers = r;
                }
            }
            Console.WriteLine("Highest number: " + numbers);
        }
        static void Arrange()
        {
            // String Star = "*";
            String result = "";

            for (int i = 0; i < 4; i++)
            {
                /* Console.WriteLine(Star);
                 for(i = 2; i< 10; i++)
                 {
                     Console.WriteLine(Star + Star);
                     for(i = 4; i < 10; i++)
                     {
                         Console.WriteLine(Star + Star + Star);
                         for(i = 6; i == 6; i++)
                         {
                             Console.WriteLine(Star + Star + Star + Star);
                             return;
                         }
                     }
                 }*/

                result += "*";
                Console.WriteLine(result);
            }
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4-i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void ArraySample()
        {
            int[] arr = new int[5];
            arr[0] = 4;
            arr[4] = 6;

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = 99;
                Console.WriteLine("Index [" + i + "]" + arr[i]);
            }
        }
        static void ArrInput() // Task
        {
            int[] arr = new int[5];
           
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Input Array elements: ");
                int elem = Convert.ToInt32(Console.ReadLine());
                arr[i] = elem;
                // Or arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Array index [" + i + "] " + arr[i]);
            }
            Console.WriteLine();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Array index [" + i + "] " + arr[i]);
                
            }
            /*int[] arr2 = new int[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
                Console.WriteLine("Input Array elements: " + (arr2.Length+1));
                arr[arr2.Length - 1] = Convert.ToInt32(Console.ReadLine());

            }*/
        }

    }
}
