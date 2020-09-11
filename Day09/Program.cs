using Day08FileIO;
using System;
using System.Collections.Generic;

namespace Day09
{
    class Program
    {
        static void Main(string[] args)
        {
            Task02();
        }
        static void Task01()
        {
            Console.WriteLine("Enter file name: ");
            String name = Console.ReadLine();

            //FileOperations.Write(name);

            //FileOperations.Read(name);
        }
        static void Task02()
        {
            Console.WriteLine("Enter file name: ");
            String name = Console.ReadLine();

            List<String> List = new List<String> { "da", "fse", "gwg" };
            FileOperations.Write(List, name);

            FileOperations.Read(name);
        }
    }
}
