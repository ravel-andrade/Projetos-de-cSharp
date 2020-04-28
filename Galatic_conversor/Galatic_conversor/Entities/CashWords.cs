using System;
using System.Collections.Generic;
using System.Text;

namespace Galatic_conversor.Entities
{
    class CashWords
    {
        public String Word { get; set; }
        public int Value { get; set; }

        public CashWords(){}

        public CashWords(string word, char c)
        {
            Word = word;
            
            switch (c)
            {
                case 'I':
                    Value = 1;
                    break;
                case 'V':
                    Value = 5;
                    break;
                case 'X':
                    Value = 10;
                    break;
                case 'L':
                    Value = 50;
                    break;
                case 'C':
                    Value = 100;
                    break;
                case 'D':
                    Value = 500;
                    break;
                case 'M':
                    Value = 1000;
                    break;
                default:
                    Console.WriteLine("Invalid char. "+ c +" = I");
                    Value = 1;
                    break;

            }
                
        }

    }
}
