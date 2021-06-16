using System;
namespace Сoursework
{
    public abstract class Task
    {
        public void Start() {
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("Starting task " + TaskNumber + "...\n");
            Main();
            Console.WriteLine("\nTask " + TaskNumber + " ended.");
        }

        public abstract void Main();
        public abstract int TaskNumber { get; }
    }
}
