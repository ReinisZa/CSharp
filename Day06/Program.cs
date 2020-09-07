
using System;

namespace Day6_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.color = "Red";
            car1.brand = "Volkswagen";
            car1.model = "Jetta";

            Car car2 = new Car();
            car2.color = "White";
            car2.brand = "BMW";
            car2.model = "M3";

            car1.PrintInfo();

            car2.PrintInfo();

        }
    }
}