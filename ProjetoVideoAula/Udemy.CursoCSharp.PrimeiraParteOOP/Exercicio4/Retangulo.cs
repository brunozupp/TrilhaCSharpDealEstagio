using System;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio4
{
    public class Retangulo
    {
        public double Largura { get; private set; }

        public double Altura { get; private set; }

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura * 2) + (Altura * 2);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
    }
}
