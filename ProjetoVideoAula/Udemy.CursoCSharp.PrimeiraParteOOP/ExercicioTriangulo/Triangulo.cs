using System;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.ExercicioTriangulo
{
    public class Triangulo
    {
        public double LadoA { get; private set; }
        public double LadoB { get; private set; }
        public double LadoC { get; private set; }

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        public double Perimetro()
        {
            return (LadoA + LadoB + LadoC) / 2.0;
        }

        public double Area()
        {
            double perimetro = Perimetro();

            return Math.Sqrt(perimetro * (perimetro - LadoA) * (perimetro - LadoB) * (perimetro - LadoC));
        }
    }
}
