using System;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(args[0]);
            double height = double.Parse(args[1]);

            TriangularBasedPrism triangular =  new TriangularBasedPrism();
            triangular.RadiusBaseInscribedCircle = radius;
            triangular.Height = height;

            SquareBasedPrism square = new SquareBasedPrism();
            square.RadiusBaseInscribedCircle = radius;
            square.Height = height;

            System.Console.WriteLine($"Para el prisma con base triangular el area es: {triangular.GetPrismArea()}\n");

            System.Console.WriteLine($"Para el prisma con base cuadrada el area es: {square.GetPrismArea()}");

            Console.ReadKey();
        }
    }
}
