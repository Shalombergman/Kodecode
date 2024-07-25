using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class Person

    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value <= 0 || value > 99)
                {
                    Console.WriteLine("Error: the age is not ok" + value);
                }
                else
                {
                    _age = value;
                    Console.WriteLine(_age);
                }
            }
        }
        public void printArray()
        {
            int[] steps = { 1, 2, 3, 4, 5 };
            Array.Sort(steps);
            int result = Array.Find(steps, step => step == 3);
        }
        //private int findStep(int[] steps, int stepToFind)
        //{

        //    foreach (int step in steps)
        //    {
        //        if (step == 3)
        //        {
        //            return step;
        //        }
        //    }
        public void sortArray()
        {
            int[]
        }
    }
}
