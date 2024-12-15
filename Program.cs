using Prac1.Controllers;

namespace Prac1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var controller = new TaskController();
            controller.Run();
        }
    }
}