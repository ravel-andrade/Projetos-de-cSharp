using System;
using System.Collections.Generic;
using System.Globalization;

namespace Fixacao_List {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Quantos empregados serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Empregado> list = new List<Empregado>();

            for(int i = 1; i <= n; i++) {
                Console.WriteLine("Id do empregado #" + i + ": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome do empregado: ");
                String nome = Console.ReadLine();
                Console.Write("Salário do empregado: ");
                Double salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;
                list.Add(new Empregado(id, nome, salario));
            
            }

            Console.Write("Digite o id do empregado que receberá aumento: ");
            int idEmpregado = int.Parse(Console.ReadLine());

            Empregado emp = list.Find(x => x.Id == idEmpregado);
            if(emp != null) {
                Console.Write("Quantos % será de aumento? ");
                Double porcentagem = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                emp.AumentaSalario(porcentagem);
            }
            else {
                Console.WriteLine("Id invalido");
            }

            Console.WriteLine("Lista de empregados atualizada: ");

            foreach (Empregado obj in list) {
                Console.WriteLine(obj);

            }

            
        }
    }
}
