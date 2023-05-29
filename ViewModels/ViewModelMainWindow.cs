using sudoku.Models;
using sudoku.ViewModels.basa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudoku.ViewModels
{
    internal class ViewModelMainWindow : ViewModel
    {
        private int?[][] board;
        private int[][] solution;
        public int?[][] Board => board;
        public int[][] Solution => solution;

        private static readonly Random random = new Random();
        public void GenerateSudoku()
        {
            GenerateSolution();
            SetupBoard();
        }
        private void SetupBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = new int?[9];
                for (int j = 0; j < 9; j++)
                    board[i][j] = solution[i][j];
            }

            int remainingItems = 20;
            while (remainingItems > 0)
            {
                int posX = random.Next(9);
                int posY = random.Next(9);
                if (board[posX][posY] == null)
                    continue;
                board[posX][posY] = null;
                remainingItems--;
            }
        }
        private void GenerateSolution()
        {
            solution = new int[9][];
            var availableNumbers = new List<int>[9];

            for (int x = 0; x < availableNumbers.Length; x++)
                availableNumbers[x] = new List<int>(numbers);

            solution[0] = numbers.Shuffle();
            for (int i = 0; i < 9; i++)
                availableNumbers[i].Remove(solution[0][i]);

            int row = 1;
            int rowTries = 0;

            while (row < 9)
            {
                var rowAvailableNumbers = new List<int>(numbers.Shuffle());
                int[] currentRow = new int[9];
                List<int>[] used = new List<int>[9];
                for (var i = 0; i < used.Length; i++)
                    used[i] = new List<int>(2);
                int pos = 0;
                while (pos < 9)
                {
                    int num = rowAvailableNumbers.FirstOrDefault(
                        x => availableNumbers[pos].Contains(x) && !used[pos].Contains(x));
                    if (num != 0)
                    {
                        currentRow[pos] = num;
                        used[pos].Add(num);
                        rowAvailableNumbers.Remove(num);
                        pos++;
                    }
                    else
                    {
                        used[pos].Clear();
                        pos--;
                        rowAvailableNumbers.Add(currentRow[pos]);
                        currentRow[pos] = 0;
                    }
                }
                solution[row] = currentRow;
                for (int i = 0; i < 9; i++)
                    availableNumbers[i].Remove(solution[row][i]);
                row++;
                if (row % 3 == 0)
                    if (!BoxCheck(row / 3 - 1))
                    {
                        row--;
                        for (int i = 0; i < solution[row].Length; i++)
                            availableNumbers[i].Add(solution[row][i]);
                        rowTries++;
                        if (rowTries > 9)
                        {
                            row--;
                            for (int i = 0; i < solution[row].Length; i++)
                                availableNumbers[i].Add(solution[row][i]);
                            rowTries = 0;
                        }
                    }
                    else
                        rowTries = 0;
            }
        }

        readonly int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private bool BoxCheck(int i)
        {
            for (int j = 0; j < 3; j++)
            {
                var freeNumbers = new List<int>(numbers);
                if (freeNumbers.Count > 0)
                    return false;
            }
            return true;
        }

    }
}
