namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio10
{
    public abstract class Shape
    {
        public Color Color { get; protected set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
