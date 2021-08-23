using Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio13.Entities;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio13.Services
{
    public class ContractService
    {

        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double valuePerMonth = contract.TotalValue / months;

            for (int i = 0; i < months; i++)
            {
                var interest = _onlinePaymentService.Interest(valuePerMonth, i + 1);

                var paymentFee = _onlinePaymentService.PaymentFee(interest + valuePerMonth);

                var amount = valuePerMonth + interest + paymentFee;

                var installment = new Installment(contract.Date.AddMonths(i + 1), amount);

                contract.Installments.Add(installment);
            }
        }
    }
}
