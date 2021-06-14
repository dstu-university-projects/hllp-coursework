using System;

namespace Сoursework
{
    class Program
    {
        static void Main(string[] args)
        {

            var tasks = new Task[] {
                new Task1(),

            };

            foreach (Task task in tasks) {
                task.Start();
            }
        }
    }
}
