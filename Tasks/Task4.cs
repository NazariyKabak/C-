using System;
using System.Linq;
using Prac1.Interfaces;

namespace Prac1.Tasks
{
    public class Task4 : ITask
    {
        public void Execute()
        {
            int studentNumber = 5;
            int length = 10 + studentNumber;
            var random = new Random();
            int [] xArray = Enumerable.Range(0,length).Select(_ => random.Next(-100,101)).ToArray();
            
            Console.WriteLine("Введіть число M:");
            if (!int.TryParse(Console.ReadLine(), out int m))
            {
                Console.WriteLine("Некоректний ввід");
                return;
            }
            int[] yArray = xArray.Where(n => Math.Abs(n) > m).ToArray();
            Console.WriteLine($"Масив X: {string.Join(", ", xArray)}");
            Console.WriteLine($"Число M: {m}");
            Console.WriteLine($"Масив Y: {string.Join(", ", yArray)}");
        }
    }
}