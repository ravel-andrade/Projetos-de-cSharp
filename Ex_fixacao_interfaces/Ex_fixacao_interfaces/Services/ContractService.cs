using Ex_fixacao_interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_fixacao_interfaces.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            this._onlinePaymentService = onlinePaymentService;
        }

        public void processContract (Contract contract, int months)
        {
            double value = contract.totalValue / months;
            
            for (int i = 0; i < months; i++) {
                DateTime date = contract.date.AddMonths(i+1);
                Double quotaValue = value + _onlinePaymentService.interest(value, i+1);
                quotaValue = quotaValue + _onlinePaymentService.paymentFee(quotaValue);
                
                contract.installments.Add(new Installment(date, quotaValue));
            }
        }
    }
}
