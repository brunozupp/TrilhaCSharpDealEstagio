using System;
using Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio14.Enums;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio14.Entities
{
    public class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return $"Circle area = ${area()}";
        }
    }
}
