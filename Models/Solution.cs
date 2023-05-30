using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudoku.Models
{
    class Solution
    {
                private int[][] solution;
        private int [][] GenerateSolution()
        {
            //solution = new int[9][];
            //var availableNumbers = new List<int>[9];
            for (int i = 0;i < solution.Length; i++)
            {
                solution[i] = numbers.Shuffle();
            }
            //solution[0] = numbers.Shuffle();
            //availableNumbers[].Remove(solution[0][i]);
            return solution;
        }

        private bool BoxCheck(int i)
        {
            for (int j = 0; j < 3; j++)
            {
                var freeNumbers = new List<int>(numbers);
                for (int x = 0; x < 3; x++)
                    for (int y = 0; y < 3; y++)
                        freeNumbers.Remove(solution[i * 3 + x][j * 3 + y]);
                if (freeNumbers.Count > 0)
                    return false;
            }
            return true;
        }

        private static readonly Random random = new Random();

        readonly int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    }
}
