using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Student_marks
    {
        private int _physics, _maths, _chemistry;
        public int[] Students_mark = new int[3];

        public int Physics_marks
        {
            get { return _physics; }
            set { if (value > 100)
                {
                    Console.WriteLine("Enter a Valid Marks");
                }
                else
                _physics = value;
            }
        }
        public int Maths_marks
        {
            get { return _maths; }
            set
            {
                if (value > 100 )
                {
                    Console.WriteLine("Enter a Valid Marks");
                }
                else
                _maths = value;
            }
        }
        public int Chemistry_marks
        {
            get { return _chemistry; }
            set
            {
                if (value > 100)
                {
                    Console.WriteLine("Enter a Valid Marks");

                }
                else
                {
                    _chemistry = value;
                }
            }
        }
        public void marks()
        {
            Console.WriteLine("Enter Student Marks in Physics Chemistry Maths :");

            for (int j = 0; j < Students_mark.Length; j++)
            {
                Students_mark[j] = Convert.ToInt32(Console.ReadLine());
            }
            
        }

    }

}
