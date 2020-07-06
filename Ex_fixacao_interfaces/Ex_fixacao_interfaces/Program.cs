using Ex_fixacao_interfaces.Entities;
using Ex_fixacao_interfaces.Services;
using System;
using System.Globalization;


namespace Ex_fixacao_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract myContract = new Contract(number, date, value);

            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            ContractService contractService = new ContractService(new PaypalService());
            contractService.processContract(myContract, installments);

            Console.WriteLine("Installments:");
            foreach (Installment installment in myContract.installments)
            {
                Console.WriteLine(installment);
            }

        }
    }
}
