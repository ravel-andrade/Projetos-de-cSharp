using Ex_fix_exeptions.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_fix_exeptions.Entities
{
    class Account
    {
        public int Number { get; set; }
        public String Holder { get; set; }
        public Double Balance { get; set; }
        public Double WithDrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, String holder, Double balance, Double withDrawLimit)
        {
            
                Number = number;
                Holder = holder;
                Balance = balance;
                WithDrawLimit = withDrawLimit;
            
            
        }

        public void Deposit(Double amount)
        {
            Balance += amount;
        }

        public void WithDraw(Double amount)
        {
            if (amount > WithDrawLimit)
            {
                throw new DomainException("the amount is bigger than the with draw limit of this account");
            }
            if (amount > Balance)
            {
                throw new DomainException("the amount is bigger than the balance of this account");
            }

            

            Balance -= amount;
            Console.WriteLine("New balance: "+ Balance);

        }

        
    }
}
