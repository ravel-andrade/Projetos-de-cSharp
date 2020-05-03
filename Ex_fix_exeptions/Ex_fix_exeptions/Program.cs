using Ex_fix_exeptions.Entities;
using Ex_fix_exeptions.Entities.Exceptions;
using System;
using System.Globalization;

namespace Ex_fix_exeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                String holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                Double balance = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
                Console.Write("Withdraw balance: ");
                Double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, balance, withDrawLimit);
                Console.WriteLine("");
                Console.Write("Enter amount for withdraw: ");
                Double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.WithDraw(amount);

            }
            catch (DomainException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }
    }
}
