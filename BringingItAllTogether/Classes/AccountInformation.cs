using System;
using System.Collections.Generic;
using System.Text;

namespace BringingItAllTogether.Classes
{
    public class AccountInformation
    {
        private string owner;
        private float balance;

        //need to further explore properties below to find other ways of using it.
        public float Balance
        {
            get
            {
                return balance;
            }
            // "private" means that the "set" can only be set within this class.
            private set
            {
                // "value" is the value that is being assigned to the Balance
                if (value >= 0f)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("No funds are in the account");
                }
            }
        }

        //constructor
        public AccountInformation(float balance, string owner)
        {
            Balance = balance;
            this.owner = owner;
        }

        //adds additional funds to the balance
        public float AddBalance(float balanceToBeAdded)
        {
            Balance = balance + balanceToBeAdded;
            return Balance;
        }

        //using the overloaded method will allow me to set the variable instead of the property and allow a negative balance.
        public float AddBalance(float balanceToBeAdded, bool balanceCanBeNegative)
        {
            //setting the variable only with the bool condition
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

    //Inheritance
    //added a parent for their child's account

    public class ChildAccountInformation : AccountInformation
    {
        public string Parent { get; set; }
                                                                                    //"base" needs the parameters from the object class
        public ChildAccountInformation(float balance, string owner, string parent) : base(balance, owner)
        {
            Parent = parent;
        }
    }

}
