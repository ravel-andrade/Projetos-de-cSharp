﻿using Ex_abst.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ex_abst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            List<TaxPayer> list = new List<TaxPayer>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Helth expeditures: ");
                    double helthExpeditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, helthExpeditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }

            }

            Console.WriteLine("TAXES PAID: ");
            Double totalTaxes = 0;
            foreach (TaxPayer payer in list)
            {
                Console.WriteLine(payer.Name + ": $" + payer.Tax().ToString("F2"), CultureInfo.InvariantCulture);
                totalTaxes += payer.Tax();
            }

            Console.WriteLine("TOTAL TAXES: " + totalTaxes.ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}
