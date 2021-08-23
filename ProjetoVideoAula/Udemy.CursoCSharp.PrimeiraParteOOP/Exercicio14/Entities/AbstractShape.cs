using Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio14.Enums;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio14.Entities
{
    // Ele pede para eu implementar o método mesmo sendo uma classe abstrata
    // aí só implementa daquela forma que é sucesso, vai repassar pras classes filhas implementar
    public abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        protected AbstractShape(Color color)
        {
            Color = color;
        }

        public abstract double area();
    }
}
