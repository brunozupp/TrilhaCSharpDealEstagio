namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio13.Services
{
    public interface IOnlinePaymentService
    {
        // Taxa de pagamento
        double PaymentFee(double amount);

        // Juro simples
        double Interest(double amount, int months);
    }
}
