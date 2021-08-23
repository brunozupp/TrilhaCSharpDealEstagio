using System;
using System.Collections.Generic;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio10
{
    public class ExercicioExecutar10
    {
        public static void Executar()
        {
            List<Shape> shapes = new List<Shape>();

            var circle = new Circle(Color.BLACK, 3.0);
            var rectangle = new Rectangle(Color.BLUE, 4.0, 5.0);

            shapes.Add(circle);
            shapes.Add(rectangle);

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area());
            }
        }
    }
}
