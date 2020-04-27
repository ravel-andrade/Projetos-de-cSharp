using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Ex_abst.Entities
{
    class Individual : TaxPayer
    {
        public Double HelthExpeditures { get; set; }

        public Individual(String name, double anualIncome, double helthExpeditures) : base(name, anualIncome)
        {
            HelthExpeditures = helthExpeditures;
        }

        public override double Tax()
        {
            double tax = 0;

            if (AnualIncome < 20000.00)
            {
                tax = AnualIncome * 0.15;
            }
            else
            {
                tax = AnualIncome * 0.25;
            }

            if (HelthExpeditures > 0)
            {
                tax -= HelthExpeditures * 0.5;
            }
            return tax;
        }
    }
}
