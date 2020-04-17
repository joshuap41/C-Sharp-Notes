using System;
using BringingItAllTogether.Classes;


namespace BringingItAllTogether
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine(Math.Add(35, 35));

            AccountInformation accountInformation1 = new AccountInformation(1000f, "Joshua Johnson");

            ChildAccountInformation accountInformation2 = new ChildAccountInformation(100f, "Chris Johnson", "Joshua Johnson");

            AccountInformation accountInformation3 = new AccountInformation(200f, "Frank Roney");


            Console.WriteLine(accountInformation2.Parent);


            Console.WriteLine(accountInformation2.Balance);

            Console.WriteLine(accountInformation2.AddBalance(-100000f));

            //uses the overloaded method - Cool!
            Console.WriteLine(accountInformation2.AddBalance(-100000f, true));

            Console.ReadLine();
        }
    }



    class Math
    {
        public static float Add(float n1, float n2)
        {
            return n1 + n2;
        }
        public static float Subtract(float n1, float n2)
        {
            return n1 - n2;
        }
        public static float Multiply(float n1, float n2)
        {
            return n1 * n2;
        }
        public static float Divide(float n1, float n2)
        {
            return n1 / n2;
        }
    }
}
