using System;

namespace VariablesAndMethods
{
    class Program
    {
        //static => nothing is needed to run the method
        //void => doesn't return anything
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(Add(5, 5));

            AddSecond(10, 10);

            Console.ReadLine();
        }

        //a way of using a method to "return" a value.
        private static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        //this way of using a method doesn't "return" a value but it takes care of the entire process.
        //everything inside of this method only exists inside this method Via "void"
        private static void AddSecond(int n1, int n2)
        {
            int result;
            result = n1 + n2;

            Console.WriteLine(result);
        }
    }
}
