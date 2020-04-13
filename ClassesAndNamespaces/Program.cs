using System;
using ClassesAndNamespaces.Classes;


namespace ClassesAndNamespaces
{

    //the classes must be all "static" to be able to have access to the methods IF they are in the same exact "namespace"
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SimpleMath.Add(23.4f, 23.4f));


            //defines an object "creates a new instance"
            //creates the bank accounts and then gives them values.
            //I am using the BankAccount class to hold data for different people.
            BankAccount bankAccount1 = new BankAccount(100f, "Joshua Johnson");

            BankAccount bankAccount2 = new BankAccount(50f, "Jaclyn Johnson");
            

            //adds money to the bankAccount(s) using the AddBalance bethod.
            Console.WriteLine(bankAccount1.AddBalance(100f));
            Console.WriteLine(bankAccount2.AddBalance(100f));


            Console.ReadLine();
        }
    }



    class SimpleMath
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
