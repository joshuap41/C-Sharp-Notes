using System;

namespace VariablesMethodsChallenge
{
    class Program
    {
        //class level variables
        static int n1 = 10, n2 = 20;
        private static void Main(string[] args)
        {
            var result = Add();
            var resultNeg = Subtract();
            var resultMultiply = Multiply();
            var resultDivide = Divide();

            Console.WriteLine(result);
            Console.WriteLine(resultNeg);
            Console.WriteLine(resultMultiply);
            Console.WriteLine(resultDivide);

            Console.ReadLine();
        }

        private static int Add()
        {
            return n1 + n2;
        }


        private static int Subtract()
        {
            return n1 - n2;
        }

        private static int Multiply()
        {
            return n1 * n2;
        }

        private static int Divide()
        {
            return n1 / n2;
        }
    }
}
