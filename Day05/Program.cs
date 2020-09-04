using System;
using System.Collections.Generic;

namespace Day05
{
    class Program
    {
        static void Main(string[] args) // Cuerently initialized Task02 - Menu
        {
            List<String> values = new List<String>();
            
            Task02(values);
        }
        static void ListSample()
        {
            List<String> lst = new List<String>();

            lst.Add("aa");
            lst.Add("bb");

            for(int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i]);
                lst[i] = "lll";
            }

            foreach(String value in lst)
            {
                Console.WriteLine(value);
            }
        }

        static void Task01()
        {
            double a = InputDouble(1);

            double b = InputDouble(1);

            Console.Write("Choose one - sum, sub, time, div: ");
            String choice = Console.ReadLine();

            if (choice == "sum")
            {
                Console.WriteLine(Calculator.Sum(a, b));
            }
            else if (choice == "sub")
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
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
        static double InputDouble(int number) // Creates a loop in case of wrong input
        {
            double result = 0;
            try
            {
                Console.Write("Input " + number + " number: ");
                result = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                result = InputDouble(number);
            }

            return result;
        }
        static void Task02(List <String> values)
        {
            String choice = "";
            while(choice != "Exit")
            {
                Console.Write("Choose an action - Add, Show, Exit: ");
                choice = Console.ReadLine();

                if (choice == "Add")
                {
                    Console.Write("How many values would you like to add? : ");
                    int amount = Convert.ToInt32(Console.ReadLine());

                    for(int i = 0; i < amount; i++)
                    {
                        Console.Write("Insert value [" + i + "]: ");
                        values.Add(Convert.ToString(Console.ReadLine()));
                    }
                }
                else if(choice == "Show")
                {
                    if (values.Count == 0)
                    {
                        Console.WriteLine("List contains no values!");
                    }
                    for (int i = 0; i < values.Count; i++)
                    {
                        Console.WriteLine("Value [" + i + "] is " + values[i]);

                    }
                }
            }
        }
    }
}
