using Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio14.Enums;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio14.Entities
{
    public class Rectangle : AbstractShape
    {

        public double Height { get; set; }

        public double Width { get; set; }

        public Rectangle(Color color, double height, double width) : base(color)
        {
            Height = height;
            Width = width;
        }

        public override double area()
        {
            return Height * Width;
        }

        public override string ToString()
        {
            return $"Rectangle area = ${area()}";
        }
    }
}
