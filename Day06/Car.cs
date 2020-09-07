
using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Objects
{
    class Car
    {
        public String brand
        {
            get
            {
                return brand; // return needed for get
            }
            set
            {
                brand = value; // sets the value of brand to the input
            }
        }
        public String model { get; set; }
        public String color;

        public void Drive()
        {
            Console.WriteLine("Brum brum");
        }

        public void PrintInfo()
        {
            Console.WriteLine(color + " " + brand + " " + model);
        }
    }
}