using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_abst.Entities
{
    abstract class TaxPayer
    {
        public String Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer(String name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract Double Tax();

    }
}
