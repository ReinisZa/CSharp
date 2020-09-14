using Day08FileIO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            Task01();
        }
        static void Task01()
        {
            List<int> values = FileOperations.Read();
            String choice = "";
            double sum = 0;
            double avg = 0;
            while (choice != "Exit")
            {
                Console.Write("Choose an action - Add, Show, Exit, Remove, Count, Average: ");
                choice = Console.ReadLine();

                if (choice == "Add")
                {
                    Console.Write("How many values would you like to add? : ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    
                    for (int i = 0; i < amount; i++)
                    {
                        try
                        {
                            Console.Write("Insert value [" + i + "]: ");
                            values.Add(Convert.ToInt32(Console.ReadLine()));
                            FileOperations.Write(values);
                        }
                        catch
                        {
                            Console.WriteLine("Wrong input");
                            i--;
                        }
                    }
                }
                else if (choice == "Show")
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
                else if (choice == "Exit")
                {
                    break;
                }
                else if (choice == "Remove")
                {
                    Console.Write("Which index would you like to remove? : ");
                    int remove = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        values.RemoveAt(remove);
                        Console.WriteLine();
                    }
                    catch
                    {
                        Console.WriteLine("Wrong input");
                    }
                    FileOperations.Write(values);
                    
                }
                else if(choice == "Count")
                {
                    for(int i = 0; i < values.Count; i++)
                    {
                        sum += values[i];
                    }
                    Console.Write("Sum of all values is: " + sum);
                    Console.WriteLine();
                    sum = 0;
                }
                else if(choice == "Average")
                {
                    for(int i = 0; i < values.Count; i++)
                    {
                        sum += values[i];
                        if(i < values.Count)
                        {
                            avg = sum / values.Count;
                        }
                    }
                    Console.WriteLine("Average of all index values is: " + avg);
                    avg = 0;
                    sum = 0;
                }
            }
        }
    }
}
