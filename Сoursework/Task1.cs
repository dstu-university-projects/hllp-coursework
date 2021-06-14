using System;
namespace Сoursework
{
    public class Task1
    {
        public void Start() {
            var input = new double[] { 10, 5, -4, 1 };
            foreach (double value in input)
            {
                CalculateZAndWriteOut(value);
            }
        }

        private void CalculateZAndWriteOut(double a)
        {
            Console.WriteLine("\nResults for a=" + a + "...");
            Console.WriteLine("z1: " + CalculateZWithSinAndCos(a));
            Console.WriteLine("z2: " + CalculateZTan(a));
        }

        private double CalculateZWithSinAndCos(double a)
        {
            return (Math.Sin(2 * a) + Math.Sin(5 * a) - Math.Sin(3 * a)) / (Math.Cos(a) - Math.Cos(3 * a) + Math.Cos(5 * a));
        }


        private double CalculateZTan(double a)
        {
            return Math.Tan(3 * a);
        }
    }
}
