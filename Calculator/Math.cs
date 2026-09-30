using System;
using System.Collections.Generic;

namespace Calc

{
    public class Math
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multipy(double a, double b) => a * b;
        public double Divide(double a, double b) => a / b;

        public long Factorial(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++) result *= i;
            return result;
        }

        public double Mod(double a, double b) => a % b;
        public double Percent(double num, double prc) => (num * prc) / 100;
        public double DPercent(double first, double last) => last / first * 100;


     
    } 
}