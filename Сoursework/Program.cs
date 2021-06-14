using System;

namespace Сoursework
{
    class Program
    {
        static void Main(string[] args)
        {

            var tasks = new Task[] {
                new Task1(),
                new Task2(),

            };

            foreach (Task task in tasks) {
                task.Start();
            }
        }
    }
}
