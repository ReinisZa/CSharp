﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day08FileIO
{
    class FileOperations
    {
        public static void Read(String name)
        {
            try
            {
                StreamReader sr = new StreamReader(name);
                String line = sr.ReadLine();

                while(line == null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine("Failed to write!");
            }
        }
        public static void Write(String name)
        {
            try
            {
                StreamWriter sw = new StreamWriter(name);
                sw.WriteLine("Hello ");
                sw.WriteLine("World!");

                sw.Close();
            }
            catch
            {
                Console.WriteLine("Failed to write!");
            }
        }
    }
}
