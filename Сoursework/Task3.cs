using System;
using System.Linq;

namespace Сoursework
{
    public class Task3 : Task
    {
        public override int TaskNumber => 3;

        public override void Main()
        {
            //1
            var array = new decimal[] { (decimal)0.3, 10, 3, -4, 5, 3, 2, -5, 4, (decimal)-0.5, 3, 7, -1, 5, 1, -6, -4, -2, 6, (decimal)0.1, 4, 1 };
            Console.WriteLine("Working with array: " + array.ToPresentationString());

            var oddElements = array.Where((_, index) => index % 2 != 0);
            var sumOfOddElements = oddElements.Aggregate((decimal)0, (acc, x) => acc += x);
            Console.WriteLine("Odd elements: " + oddElements.ToPresentationString());
            Console.WriteLine("Sum of odd elements: " + sumOfOddElements);

            //2
            var startIndex = array.FirstIndexWhere((element) => element < 0);
            var endIndex = array.LastIndexWhere((element) => element < 0);
            var sum = array[startIndex..(endIndex - 1)].Aggregate((decimal)0, (acc, x) => acc += x);

            Console.WriteLine("Sum of ragne (" + startIndex + ", " + endIndex + ") elements " + array[startIndex] + ".." + array[endIndex] + ": " + sum);

            //3
            var arrayCopy = array.Where((value) => Math.Abs(value) > 1).ToArray();
            arrayCopy = arrayCopy.Concat(Enumerable.Repeat<decimal>(0, array.Length - arrayCopy.Length)).ToArray();
            Console.WriteLine(arrayCopy.ToPresentationString());
        }

    }
}
