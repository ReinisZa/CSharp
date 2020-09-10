using System;
using System.Collections.Generic;

namespace Day08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taisnsturis> TSturis = new List<Taisnsturis>();
            int hgt = 0;
            int lgh = 0;

            for (int i = 1; i < 11; i++)
            {
                Console.Write("Enter height [ " + i + " ]: ");
                try
                {
                    hgt = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    hgt = -1;
                }

                Console.Write("Enter length [ " + i + " ]: ");
                try
                {
                    lgh = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    lgh = -1;
                }

                if (lgh < 0 || hgt < 0)
                {
                    Console.WriteLine("Wrong input.");
                    Console.WriteLine();
                }
                else
                {
                    TSturis.Add(new Taisnsturis(hgt, lgh));
                    Console.WriteLine();
                }
            }

            for(int i = 0; i < TSturis.Count; i++)
            {
                Console.Write(i + " Rectangle "); TSturis[i].PrintInfo();
            }
        }
    }
}
