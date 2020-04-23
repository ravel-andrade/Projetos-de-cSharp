using System;

namespace Pensionato {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Quantos quarto serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Quarto[] lista = new Quarto[10];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite o nome do cliente de numero "+i);
                String nome = Console.ReadLine();
                Console.WriteLine("Digite o email do cliente de numero " + i);
                String email = Console.ReadLine();
                int numero;

                Console.WriteLine("Digite o quarto do cliente de numero " + i);

                do {
                     numero = int.Parse(Console.ReadLine());
                    if (numero < 0 || numero > 10) {
                        Console.WriteLine("Valor invalido, favor entre com um valor novamente (0-9)");
                    }
                    else {
                        if (lista[numero] != null) {
                            Console.WriteLine("Quarto indisponivel, insira outro quarto: ");
                        }
                    }
                } while ((numero<0 || numero>10) || lista[numero]!=null);
                
                lista[numero] = new Quarto { Nome = nome, Email = email, Numero = numero };

            }

            Console.WriteLine("Quartos ocupados: ");

            for (int i = 0; i < 10; i++) {
                if (lista[i] != null) {
                    Console.WriteLine(lista[i].Numero + ": " + lista[i].Nome + ", " + lista[i].Email);
                }
            }
        }

        
    }
}
