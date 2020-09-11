using Day08FileIO;
using System;

namespace Day09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file name: ");
            String name = Console.ReadLine();

            FileOperations.Write(name);

            FileOperations.Read(name);
        }
    }
}
