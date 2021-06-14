using System;
namespace Сoursework
{
    public class ConsoleReader
    {
        public static decimal getNumber(string label)
        {
            decimal input;
            bool isReading;
            do
            {
                isReading = !decimal.TryParse(RequestValue(label), out input);
                if (isReading)
                {
                    Console.WriteLine("I can't read that value! Please try again...");
                }
            } while (isReading);
            return input;
        }

        public static string RequestValue(string label)
        {
            Console.WriteLine(label);
            return Console.ReadLine();
        }
    }
}
