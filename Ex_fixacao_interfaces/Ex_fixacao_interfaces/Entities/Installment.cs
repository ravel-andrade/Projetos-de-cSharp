using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ex_fixacao_interfaces.Entities
{
    class Installment
    {
        public DateTime DueTime { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueTime, double amount)
        {
            this.DueTime = dueTime;
            this.Amount = amount;
        }

        public override string ToString()
        {
            return DueTime.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
