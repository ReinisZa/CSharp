using System;
using System.Collections.Generic;
using System.Text;

namespace Day04
{
    class Sample
    {
        // private - only used in the class its created in
        // public - available among all classes
        public static void TestPrint()
        {
            Console.WriteLine("Hello World!");
            PrivatePrint();
        }
        private static void PrivatePrint()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
