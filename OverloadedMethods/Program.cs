using System;

namespace OverloadedMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        //this is a snip from the "BringingItAllTogether Project. Need to further explore.
        public float AddBalance(float balanceToBeAdded)
        {
            Balance = balance + balanceToBeAdded;
            return Balance;
        }

        //using the overloaded method will allow me to set the variable instead of the property and allow a negative balance.
        public float AddBalance(float balanceToBeAdded, bool balanceCanBeNegative)
        {
            if (balanceCanBeNegative)
            {
                balance = balance + balanceToBeAdded;
            }
            else
            {
                Balance = balance + balanceToBeAdded;
            }
            //the property will return the variable regardless of the condition, so return the property "Balance".
            return Balance;

        }


    }
}
