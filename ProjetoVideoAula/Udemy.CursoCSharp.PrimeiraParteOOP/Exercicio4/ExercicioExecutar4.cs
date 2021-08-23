using System;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio4
{
    public class ExercicioExecutar4
    {
        public static void Executar()
        {
            Retangulo r = new Retangulo(3.0, 4.0);

            Console.WriteLine($"Area = {r.Area()}");
            Console.WriteLine($"Perímetro = {r.Perimetro()}");
            Console.WriteLine($"Diagonal = {r.Diagonal()}");
        }
    }
}
