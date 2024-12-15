using System;
using System.Collections.Generic;
using Prac1.Interfaces;
using Prac1.Tasks;

namespace Prac1.Controllers
{
    public class TaskController
    {
        private readonly List<ITask> _tasks;

        public TaskController()
        {
            _tasks = new List<ITask>
            {
                new Task1(),
                new Task2(),
                new Task3(),
                new Task4()
            };
        }

        public void Run()
        {
            for (int i = 0; i < _tasks.Count; i++)
            {
                Console.WriteLine($"\nЗапуск завдання {i + 1}:");
                _tasks[i].Execute();
            }
        }
    }
}