using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day08FileIO
{
    class FileOperations
    {
        public static List<int> Read()
        {
            List<int> values = new List<int>();
            try
            {
                StreamReader sr = new StreamReader("IntegerList.txt");
                int value = Convert.ToInt32(sr.ReadLine());
                String line = sr.ReadLine();

                while(line != null)
                {
                    values.Add(value);
                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine("Failed to read!");
            }
            return values;
        }
        public static void Write(List <int> List)
        {

            try
            {
                StreamWriter sw = new StreamWriter("IntegerList.txt");

                foreach (int el in List)
                {
                    sw.WriteLine(el);
                }

                sw.Close();
            }
            catch
            {
                Console.WriteLine("Failed to write");
            }
        }
        public static void remove (List<int> values, int remove)
        {
            StreamReader sr = new StreamReader("IntegerList.txt");
            try
            {
                remove = Convert.ToInt32(Console.ReadLine());
                values.RemoveAt(remove);
 
            }
            catch
            {
                Console.WriteLine("Wrong input");
            }
        }

     
    }
}
