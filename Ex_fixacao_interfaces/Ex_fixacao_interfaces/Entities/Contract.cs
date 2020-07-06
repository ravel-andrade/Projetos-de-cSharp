using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_fixacao_interfaces.Entities
{
    class Contract
    {
        public int number { get; set; }
        public DateTime date { get; set; }
        public double totalValue { get; set; }
        public List<Installment> installments { get; private set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            this.number = number;
            this.date = date;
            this.totalValue = totalValue;
            installments = new List<Installment>();
        }


    }


}
