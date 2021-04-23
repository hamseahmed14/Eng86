using System;

namespace CalculatorLib
{
    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
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
