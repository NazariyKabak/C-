using System;
using System.Linq;
using Prac1.Interfaces;

namespace Prac1.Tasks
{
    public class Task2 : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Введіть сторони трикутника через пробіл:");
            var input = Console.ReadLine()?.Split(' ').Select(double.Parse).ToArray();
            if (input == null || input.Length != 3)
            {
                Console.WriteLine("Некоректний ввід");
                return;
            }
            double a = input[0], b = input[1], c = input[2];

            if (IsValidTriangle(a, b, c))
            {
                double perimeter = a + b + c;
                double semiPerimeter = perimeter / 2;
                double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));

                Console.WriteLine($"Периметр: {perimeter}, Площа: {area:F2}");
                Console.WriteLine($"Тип трикутника: {GetTriangleType(a, b, c)}");
            }
            else
            {
                Console.WriteLine("Трикутник не існує");
            }
        }
        private bool IsValidTriangle(double a, double b, double c)
            => a + b > c && a + c > b && b + c > a;
        private String GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return "рівносторонній";
            }
            if (a == b || b == c || a == c)
            {
                return "рівнобедрений";
            }
            return "різносторонній";
        }
        
    }
}