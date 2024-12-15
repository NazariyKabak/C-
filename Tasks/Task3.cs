using System;
using System.Linq;
using Prac1.Interfaces;

namespace Prac1.Tasks
{
    public class Task3: ITask
    {
        public void Execute()
        {
            int studentNumber = 5;
            int length = 10 + studentNumber;
            var random = new Random();
            int [] array = Enumerable.Range(0, length).Select(_ => random.Next(-100, 101)).ToArray();
            int min = array.Min();
            int max = array.Max();
            Console.WriteLine($"Масив: {string.Join(", ", array)}");
            Console.WriteLine($"Мінімальне значення: {min}, Максимальне значення: {max}");
        }
    }
}