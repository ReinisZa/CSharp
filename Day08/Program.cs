using System;
using System.Collections.Generic;

namespace Day08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 4, 5, 7 };
            int[] arr2 = { 6, 1, 4, 2 };

            ListCompare(arr1, arr2);
        }
        static void Task01()
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

            for (int i = 0; i < TSturis.Count; i++)
            {
                Console.Write(i + " Rectangle "); TSturis[i].PrintInfo();
            }
        }
        
        static List<int> ListCompare (int[] arr1, int[] arr2)
        {
            List <int> Saved = new List <int>();
            int value = 0;
            int save = 0;

            for(int i = 0; i < arr1.Length; i++)
            {
                value = arr1[i];

                for(int j = 0; j < arr2.Length; j++)
                {
                    if(value == arr2[j])
                    {
                        save = arr2[j];
                        Saved.Add(save);
                    }
                }
            }
            for(int i = 0; i < Saved.Count; i++)
            {
                Console.WriteLine("Equal values: " + Saved[i]);
            }
            return Saved;
        }
    }
}
