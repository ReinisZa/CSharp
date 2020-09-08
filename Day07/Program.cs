using System;
using System.Collections.Generic;

namespace Day07
{
    class Program
    {
        static void Main(string[] args)
        {
            Task01();
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
    }
}
