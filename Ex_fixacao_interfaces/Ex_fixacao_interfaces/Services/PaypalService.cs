using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_fixacao_interfaces.Services
{
    class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double paymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
