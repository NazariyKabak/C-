using System;
using System.Linq;
using Prac1.Interfaces;

namespace Prac1.Tasks
{
    public class Task1 : ITask
    {
        public void Execute()
        {
            int[] numbers = { 5, 15, 7 };
            int studentNumber = 5;
            int upperLimit = 10+studentNumber;
            var filteredNumbers = numbers.Where(n => n>=1 && n <= upperLimit).ToArray();
            Console.WriteLine($"Числа в межах [1, {upperLimit}]: {string.Join(", ", filteredNumbers)}");
        }
    }
}