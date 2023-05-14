using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace sudoku.Models
{
    internal class HideCells
    {
        const int n = 3;
        public Button[,] buttons = new Button[n * n, n * n];
        public void HideCells()
        {
            int N = 40;
            Random r = new Random();
            while (N > 0)
            {
                for (int i = 0; i < n * n; i++)
                {
                    for (int j = 0; j < n * n; j++)
                    {
                        if (!string.IsNullOrEmpty(buttons[i, j].Text))
                        {
                            int a = r.Next(0, 3);
                            buttons[i, j].Text = a == 0 ? "" : buttons[i, j].Text;
                            buttons[i, j].Enabled = a == 0 ? true : false;

                            if (a == 0)
                                N--;
                            if (N <= 0)
                                break;
                        }
                    }
                    if (N <= 0)
                        break;
                }
            }
        }
    }
}
