using System;
using System.Collections.Generic;
using System.Text;

namespace Day08
{
    class Taisnsturis
    {
        int area = 0;
        public int Hgt { get; set; }
        public int Lgh { get; set; }

        public int Area 
        {
            get
            {
                int area = Hgt * Lgh;
                return area;
            }
            set
            {
                Area = area;
            }
            
        }

        public Taisnsturis (int hgt, int lgh)
        {
            Hgt = hgt;
            Lgh = lgh;
            
        }

        public void PrintInfo()
        {
            Console.WriteLine(Hgt + " * " + Lgh + " = " + Area + " Area");
        }
    }
}
