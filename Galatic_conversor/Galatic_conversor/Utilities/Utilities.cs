using System;
using System.Collections.Generic;
using System.Text;
using Galatic_conversor.Entities;

namespace Galatic_conversor.Utilities
{
    static class Utilities
    {

        public static bool CheckRoman(Char c)
        {
            if (c=='I'|| c == 'V' || c == 'X' || c == 'L' || c == 'C' || c == 'D' || c == 'M')
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid char");
                return false;
            }
            
        }

        public static int TotalRomanValue(List<CashWords> cash, List<String> words)
        {
            int value = 0;
            int[] numbers = new int[words.Count];
            int count = 0;

            foreach(String x in words)
            {
                if (cash.Find(y => y.Word == x) != null)
                {
                    CashWords container = cash.Find(y => y.Word == x);
                    numbers[count] = container.Value;
                    count++;
                }
            }

            count = 0;

            for (int i = numbers.Length-1; i >=1; i--) { 
               
                if(numbers[i] == numbers[i - 1])
                {
                    if(numbers[i] == 5 || numbers[i] == 50 || numbers[i] == 500)
                    {
                        Console.WriteLine("Invalid number1");
                        Console.WriteLine(numbers[i]);
                        return 0;
                    }
                    count++;
                    if (count == 2)
                    {
                        Console.WriteLine("Invalid number2");
                        Console.WriteLine(numbers[i]);
                        return 0;
                    }
                    value = numbers[i] * 2;
                }
                

                if (numbers[i] > numbers[i - 1])
                {
                    if(numbers[i-1] == 5 || numbers[i-1] == 50 || numbers[i-1] == 500)
                    {
                        Console.WriteLine("Invalid number3");
                        Console.WriteLine(numbers[i+1]);
                        Console.WriteLine(numbers[i]);
                        Console.WriteLine(numbers[i-1]);
                        
                        return 0;
                    }
                    if (numbers[i] != 5 && numbers[i] != 10 & numbers[i-1] == 1)
                    {
                        Console.WriteLine("Invalid number4");
                        Console.WriteLine(numbers[i]);
                        return 0;
                    }
                    if (numbers[i] != 500 && numbers[i] != 1000 & numbers[i - 1] == 100)
                    {
                        Console.WriteLine("Invalid number5");
                        Console.WriteLine(numbers[i]);
                        return 0;
                    }
                    if (numbers[i] != 5 && numbers[i] != 10 & numbers[i-1] == 1)
                    {
                        Console.WriteLine("Invalid number6");
                        Console.WriteLine(numbers[i]);
                        return 0;
                    }

                    count = 0;
                    value -= numbers[i-1] ;
                }

                if (numbers[i] < numbers[i - 1])
                {
                    count = 0;
                    value += numbers[i - 1];
                }
            }


            return value;
        }
    }
}
