using System;
using System.Collections.Generic;
using System.Text;

namespace Day06Tasks
{
    class Students
    {
        public String Name;
        public String Surname;
        private int _course;
        public int Course
        {
            get
            {
                return _course;
            }
            set
            {
                _course = value;

                if (_course < 1)
                {
                    _course = 1;
                }    
                else if (_course > 3)
                {
                    _course = 3;
                }

            }
        }

        public void PrintInfo()
        {
            Console.WriteLine(Name + " " + Surname + " " + Course);
        }
    }
}
