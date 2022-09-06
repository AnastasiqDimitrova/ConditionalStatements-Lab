using System;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figureName = Console.ReadLine();
            if (figureName == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine ($"{area:f3}");
            }
            else if (figureName == "rectangle")
            {
                 double sideA = double.Parse(Console.ReadLine());
                 double sideB = double.Parse(Console.ReadLine());
                 double result = sideA * sideB;
                 Console.WriteLine($"{result:f3}");
            }
            else if (figureName == "circle")
            {
                 double radius = double.Parse(Console.ReadLine());
                 double result = radius * radius * Math.PI;
                 Console.WriteLine($"{result:f3}");
            }
            else if (figureName == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double result = sideA * sideB / 2;
                Console.WriteLine($"{result:f3}");
            }
        }
    }
}
