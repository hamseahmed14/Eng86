using System;

namespace CalculatorLib
{
    public class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            try
            {
                return a/b;
                
            }
            catch (DivideByZeroException e)
            {
                throw new ArgumentException("Cannot divide by zero");
            }
           
        }

        public static int Submit(int result)
        {
            return result;
        }
    }
}
