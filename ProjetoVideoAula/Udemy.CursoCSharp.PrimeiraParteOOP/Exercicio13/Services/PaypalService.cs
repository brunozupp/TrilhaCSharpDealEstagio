namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio13.Services
{
    public class PaypalService : IOnlinePaymentService
    {
        // Juro simples de 1% a cada parcela
        public double Interest(double amount, int months)
        {
            return amount * 0.01 * months;
        }

        // Taxa de pagamento de 2%
        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }
    }
}
