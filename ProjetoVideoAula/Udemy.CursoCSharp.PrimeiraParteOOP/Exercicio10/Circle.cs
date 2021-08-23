using System;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio10
{
    public class Circle : Shape
    {

        public double Radius { get; private set; }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
