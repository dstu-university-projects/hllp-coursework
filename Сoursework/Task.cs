using System;
namespace Сoursework
{
    abstract class Task
    {
        public void Start() {
            Console.WriteLine("Starting task " + TaskNumber + " ...");
            Main();
            Console.WriteLine("Task " + TaskNumber + " ended.\n");
        }

        public abstract void Main();
        public abstract int TaskNumber { get; }
    }
}
