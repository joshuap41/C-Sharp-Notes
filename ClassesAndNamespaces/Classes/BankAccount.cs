using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndNamespaces.Classes
{
    public class BankAccount
    {
        //using properties to secure the data: a filter for accessing/setting the data

        private float balance;
        public float Balance 
        {
            get
            {
                return balance;
            } 
            //can only set the value in this class
            private set 
            {
                if (value >= 0)
                    balance = value;
                else
                    balance = 0;
            } 
        }


        private string owner;


        //ctor shortcut to create this constructor
        //the constructor exists explicitly but I can define it by inserting it into the class
        public BankAccount(float balance, string owner)
        {
            Balance = balance;
            this.owner = owner;
        }


        public float AddBalance(float balanceToBeAdded)
        {
            balance = balance + balanceToBeAdded;
            return Balance;
        }

    }
}
