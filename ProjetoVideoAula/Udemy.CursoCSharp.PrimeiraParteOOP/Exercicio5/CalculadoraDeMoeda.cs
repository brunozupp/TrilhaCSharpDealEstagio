namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio5
{
    public class CalculadoraDeMoeda
    {
        private static double IOF = 0.06;

        public static double ConverterRealParaDolar(double cotacao, double valorEmDolar)
        {
            double valorBruto = cotacao * valorEmDolar;

            return valorBruto + (valorBruto * IOF);
        }
    }
}
