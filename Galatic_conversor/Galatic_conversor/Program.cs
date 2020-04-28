using Galatic_conversor.Entities;
using System;
using System.Collections.Generic;


namespace Galatic_conversor
{
    class Program
    {


        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\ravel\OneDrive\Área de Trabalho\Projetos-de-cSharp\Galatic_conversor\Galatic_conversor\Txt\txt.txt");
            List<String> words = new List<string>();
            List<CashWords> cashWords = new List<CashWords>();
            List<Product> products = new List<Product>();

            foreach (String line in lines)
            {
                string[] shatterdLine = line.Split(" ");

                if (shatterdLine[1] == "is")
                {
                    char c = char.Parse(shatterdLine[2]);
                    if (Utilities.Utilities.CheckRoman(c))
                    {

                        cashWords.Add(new CashWords(shatterdLine[0], c));

                    }
                 
                }


                else
                {
                    for (int i = 0; i < shatterdLine.Length; i++)
                    {

                        if (shatterdLine[i] == "is")
                        {
                            for (int j = 0; j < i - 1; j++)
                            {
                                words.Add(shatterdLine[j]);
                            }


                            String name = shatterdLine[i - 1];
                            int value = int.Parse(shatterdLine[i + 1]);
                            int sumValue = Utilities.Utilities.TotalRomanValue(cashWords, words);

                            value = value / sumValue;
                            products.Add(new Product(name, value));
                        }

                        words = new List<string>();
                        // certo
                    }
                }

                if (shatterdLine[0] == "quanto")
                {
                    for (int j = 0; j < shatterdLine.Length; j++)
                    {
                        if (j > 1 && j < shatterdLine.Length - 1)
                        {
                            words.Add(shatterdLine[j]);

                        }
                    }

                    if (Utilities.Utilities.TotalRomanValue(cashWords, words) != 0)
                    {
                        foreach (String x in words)
                        {
                            Console.Write(x + " ");
                        }
                        Console.Write(" is ");
                        Console.WriteLine(Utilities.Utilities.TotalRomanValue(cashWords, words));
                    }
                    else
                    {
                        Console.WriteLine("I have no idea what you are talking about ");
                    }


                }

                words = new List<string>();

                if (shatterdLine[0] == "quantos")
                {
                    for (int j = 3; j < shatterdLine.Length - 2; j++)
                    {
                        words.Add(shatterdLine[j]);
                        Console.Write(shatterdLine[j]+" ");

                    }

                    int n = Utilities.Utilities.TotalRomanValue(cashWords, words);
                    Product result = products.Find(x => x.Name == shatterdLine[shatterdLine.Length - 2]);
                    Console.WriteLine(result.Name + " is " + n*result.Value + " Credits");

                }


            }


        }



    }

}


