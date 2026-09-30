using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class GUIConsolApp
    {
        public double Sum(double[] array)
        {
            double s = 0;
            foreach (var x in array) s += x;
            return s;
        }

        public int Count(double[] array) => array.Length;

        public double Max(double[] array)
        {
            double max = array[0];
            foreach (var x in array) if (x > max) max = x;
            return max;
        }

        public double Min(double[] array)
        {
            double min = array[0];
            foreach (var x in array) if (x < min) min = x;
            return min;
        }

        public double[] SortAsc(double[] array)
        {
            Array.Sort(array);
            return array;
        }

        public double[] SortDesc(double[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }
    }

}

