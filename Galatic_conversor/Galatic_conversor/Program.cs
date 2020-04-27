using Galatic_conversor.Entities;
using Galatic_conversor.Utilities;
using System;
using System.Collections.Generic;

namespace Galatic_conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CashWords> cash = new List<CashWords>();
            List<String> words = new List<String>();

            cash.Add(new CashWords("um", 'I'));
            cash.Add(new CashWords("cinco", 'V'));
            cash.Add(new CashWords("dez", 'X'));
            cash.Add(new CashWords("cinquenta", 'L'));
            cash.Add(new CashWords("cem", 'C'));
            cash.Add(new CashWords("quinhentos", 'D'));
            cash.Add(new CashWords("mil", 'M'));

            words.Add("mil");
            words.Add("cem");
            words.Add("mil");
            words.Add("dez");
            words.Add("cinquenta");
            words.Add("um");
            words.Add("cinco");


            int valor = Utilities.Utilities.TotalRomanValue(cash, words);
            Console.WriteLine(valor);
        }
    }
}
