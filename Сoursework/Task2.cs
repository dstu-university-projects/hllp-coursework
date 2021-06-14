using System;

namespace Сoursework
{
    public class Task2 : Task
    {
        public override int TaskNumber => 2;

        public override void Main()
        {
            Console.WriteLine("Enter x range:");
            var xStart = ConsoleReader.getNumber("Enter x start value:");
            var xEnd = ConsoleReader.getNumber("Enter x end value:");
            var xStep = ConsoleReader.getNumber("Enter x step:");
            for (decimal x = xStart; x <= xEnd; x += xStep)
            {
                CalculateF(x);
            }
        }

        private void CalculateF(decimal x)
        {
            Console.WriteLine("\nCalculate F for x=" + x);
            var a = ConsoleReader.getNumber("Enter a: ");
            var c = ConsoleReader.getNumber("Enter c: ");

            decimal f = 0;

            if (x == 0)
            {
                if (c > 0)
                {
                    f = (x - a) / -c;
                }
            }
            else if (c < 0)
            {
                f = -a * x - c;
            }
            else if ((c - a) != 0)
            {
                var b = ConsoleReader.getNumber("Enter b: ");
                f = b * x / (c - a);
            }

            Console.WriteLine("\nF = " + f);
        }
    }
}
