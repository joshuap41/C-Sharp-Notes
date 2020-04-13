using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndNamespaces.Classes
{
    public class BankAccount
    {


        private float balance;
        private string owner;


        //ctor shortcut to create this constructor
        //the constructor exists explicitly but I can define it by inserting it into the class
        public BankAccount(float balance, string owner)
        {
            this.balance = balance;
            this.owner = owner;
        }


        public float AddBalance(float balanceToBeAdded)
        {
            return balance + balanceToBeAdded;
        }

    }
}
