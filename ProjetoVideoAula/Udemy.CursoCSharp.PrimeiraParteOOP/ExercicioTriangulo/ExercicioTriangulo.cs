using System;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.ExercicioTriangulo
{
    public class ExercicioTriangulo
    {
        public static void Executar()
        {
            Triangulo x = new Triangulo(3.0, 4.0, 5.0);

            Triangulo y = new Triangulo(7.5, 4.5, 4.02);

            Console.WriteLine($"{x.Area()} - {y.Area()}");
        }
    }
}
