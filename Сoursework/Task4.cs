using System;
using System.Collections.Generic;
using System.Linq;

namespace Сoursework
{
    public class Task4 : Task
    {
        public override int TaskNumber => 4;

        public override void Main()
        {
            var matrix = new int[][] {
                new int[] { 2, 49, -30, 7, 1},
                new int[] { 83, 1, 2, 4, 1 },
                new int[] { 5, 6, -100, 3, -4 },
                new int[] { 3, 91, 1, 7, -2 },
                new int[] { 3, -2, 1, 5, 9 },
            };
            Console.WriteLine("Working with matrix:\n" + MatrixAsString(matrix) + "\n");

            //1
            var positiveMatrix = matrix.Where(row => row.Min() >= 0);
            foreach (int[] row in positiveMatrix)
            {
                var index = Array.IndexOf(matrix, row);
                Console.WriteLine("Multiplied numbers of row at index " + index + ": " + row.Aggregate(1, (acc, x) => acc * x));
            }

            //2
            var diagonals = new Dictionary<int,List<int>>();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (i == j) continue;
                    var index = i - j;
                    try { diagonals.Add(index, new List<int>() { matrix[i][j] }); }
                    catch { diagonals[index].Add(matrix[i][j]); }
                }
            }
            var sumOfDiagonalElements = new List<int>();
            foreach (int key in diagonals.Keys.OrderBy(key => key))
            {
                var sum = diagonals[key].Aggregate(0, (acc, x) => acc += x);
                Console.WriteLine("diagonal " + key + ": " + diagonals[key].ToPresentationString() + "; sum of elements: " + sum);
                sumOfDiagonalElements.Add(sum);
            }
            Console.WriteLine("max of diagolal sums — " + sumOfDiagonalElements.Max());
        }



        static string MatrixAsString(int[][] matrix)
        {
            var longlest = matrix.Select(row => row.Select(item => item.ToString().Length).Max()).Max();
            string s = "";
            foreach (int[] row in matrix)
            {
                s += "\n| ";
                foreach (int item in row)
                    s += item.ToString().PadLeft(longlest) + " ";
                s += "|";
            }
            return s;
        }
    }
}
