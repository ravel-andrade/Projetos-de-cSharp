using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Fixacao_List {
    class Empregado{
        public int Id { get; set; }
        public String Nome { get; set; }
        public Double Salario { get; set; }

        public Empregado(int id, String nome, Double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentaSalario(Double porcentagem) {
            Salario += Salario * porcentagem / 100;

        }

        public override string ToString() {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
