using System;

namespace CalculatorLib
{
    public static class Calculator
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
                return a / b;
            }
            catch (DivideByZeroException) {
                return 0;
                    }
        }

        public static int Modulus(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }

            return a % b;
        }
    }

}
