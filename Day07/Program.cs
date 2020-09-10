using System;
using System.Collections.Generic;

namespace Day07
{
    class Program
    {
        static void Main(string[] args)
        {
            Homework();
        }
        static void Task01()
        {
            List<Students> StudentsLst = new List<Students>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter student name: ");
                String name = Console.ReadLine();

                Console.Write("Enter student surname: ");
                String surname = Console.ReadLine();

                Console.Write("Enter student course: ");
                int course = Convert.ToInt32(Console.ReadLine());

                StudentsLst.Add(new Students(name, surname, course));

            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                StudentsLst[i].PrintInfo();
            }
        }
        static void Homework()
        {
            List<Students> StudentsLst = new List<Students>();
            String choice = "";

            while (choice != "Exit")
            {
                Console.Write("Choose an action - Add, Show, Exit, Remove: ");
                choice = Console.ReadLine();
                int values = StudentsLst.Count;
                Console.WriteLine();

                if (choice == "Add")
                {
                    Console.Write("How many entries would you like to add? : ");
                    int count = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();

                    for (int i = 0; i < count; i++)
                    {
                        Console.Write("Enter student name: ");
                        String name = Console.ReadLine();

                        Console.Write("Enter student surname: ");
                        String surname = Console.ReadLine();

                        Console.Write("Enter student course: ");
                        int course = Convert.ToInt32(Console.ReadLine());

                        StudentsLst.Add(new Students(name, surname, course));
                    }
                }
                else if (choice == "Show")
                {
                    for (int i = 0; i < values; i++)
                    {
                        StudentsLst[i].PrintInfo();
                        Console.WriteLine();
                    }

                    if (StudentsLst.Count == 0)
                    {
                        Console.WriteLine("List contains no values!");
                        Console.WriteLine();
                    }
                }
                else if (choice == "Remove")
                {
                    Console.WriteLine("Which index would you like to remove? : ");
                    int remove = 0;
                    try
                    {
                        remove = Convert.ToInt32(Console.ReadLine());
                        StudentsLst.RemoveAt(remove);
                    }
                    catch
                    {
                        Console.WriteLine("Wrong input");
                    }

                }
   
            }
        }
    }
}
