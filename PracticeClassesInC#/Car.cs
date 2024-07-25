using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_Classes_in_C_
{
    internal class Car
    {
        private Color CarColor;
        public Car(Color carColor)
        {
            CarColor = carColor;
        }
        public void DisplayColor()
        {
            Console.WriteLine(CarColor.ToString());
        }
    }
}
