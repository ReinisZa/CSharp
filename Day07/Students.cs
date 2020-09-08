using System;
using System.Collections.Generic;
using System.Text;

namespace Day07
{
    class Students
    {
        public String Name { get; set; }
        public String Surname { get; set; }
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

        public Students(String name, String surname, int course)
        {
            Name = name;
            Surname = surname;
            Course = course;

        }

        /*public Students()
        {
            Console.Write("Enter name: ");
            String name = Console.ReadLine();
            Name = name;
            Console.Write("Enter surname: ");
            String surname = Console.ReadLine();
            Surname = surname;
            Console.Write("Enter Course: ");
            int course = Convert.ToInt32(Console.ReadLine());
            Course = course;
        }*/

        public void PrintInfo()
        {
            Console.WriteLine(Name + " " + Surname + " " + Course);
        }
    }
}
