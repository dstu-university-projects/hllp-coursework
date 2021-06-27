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
                new Task3(),
                new Task4(),
                new Task5()
            };

            foreach (Task task in tasks) {
                task.Start();
            }
        }
    }
}
