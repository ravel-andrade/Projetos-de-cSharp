using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_fixacao_interfaces.Services
{
    interface IOnlinePaymentService
    {
        public double paymentFee(double amount);
        public double interest(double amount, int months);
    }
}
