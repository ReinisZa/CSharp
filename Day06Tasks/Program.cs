using System;

namespace Day06Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Students student1 = new Students();
            Console.Write("Enter name: ");
            student1.Name = Console.ReadLine();
            Console.Write("Enter surname: ");
            student1.Surname = Console.ReadLine();
            Console.Write("Enter Course: ");
            student1.Course = Convert.ToInt32(Console.ReadLine());

            Students student2 = new Students();
            Console.Write("Enter name: ");
            student2.Name = Console.ReadLine();
            Console.Write("Enter surname: ");
            student2.Surname = Console.ReadLine();
            Console.Write("Enter Course: ");
            student2.Course = Convert.ToInt32(Console.ReadLine());

            Students student3 = new Students();
            Console.Write("Enter name: ");
            student3.Name = Console.ReadLine();
            Console.Write("Enter surname: ");
            student3.Surname = Console.ReadLine();
            Console.Write("Enter Course: ");
            student3.Course = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            student1.PrintInfo();
            Console.WriteLine();
            student2.PrintInfo();
            Console.WriteLine();
            student3.PrintInfo();
        }
        static void Input()
        {

        }
    }
}
