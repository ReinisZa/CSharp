using System;
using System.Dynamic;

namespace Day03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array(4);

            ArrArrange(arr);

        }

        static void Arr()
        {
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            ClearArr(arr);
        }
        static void ClearArr (int [] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 0;
            }
        }
        static int [] ArrRandom(int length)
        {
            Random ran = new Random();

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                int r = ran.Next(100);

                arr[i] = r;
            }
            return arr;
        }
        static int[] ClearArr2(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 50)
                {
                    a[i] = 0;
                }
                Console.Write(a[i] + " ");
            }
            return a;
        }
        static int StringLength(string [] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                int size = arr[i].Length; // Converts array index value to int
                sum += size;
            }
            return sum;
        }
        static int[] Array(int length)
        {
            int[] arr = new int[length];

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter Array values: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
        static int [] ArrArrange (int [] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                
                for(int j = 0; j < arr.Length; j++)
                {
                 
                 
                   
                }
                Console.Write(num + " ");
            }

            return arr;
        }
    }
}
