using sudoku.Models;
using sudoku.ViewModels.basa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace sudoku.ViewModels
{
    internal class ViewModelMainWindow : ViewModel
    {
        private Random random;
        const int n = 3;
        public int[,] map = new int[n * n, n * n];
        public Button[,] buttons = new Button[n * n, n * n];
        public void GenerateMap()
             {
                        for (int i = 0; i < n * n; i++)
                        {
                            for (int j = 0; j < n * n; j++)
                            {
                                map[i, j] = (i * n + i / n + j) % (n * n) + 1;
                                buttons[i, j] = new Button();
                            }
                        }
                        Random random= new Random();
                for (int i =0; i<40; i++)
                {
                    ShuffleMap(random.Next(0, 5));
                }
                CreateMap();
                HideCells();
            }
        public void CreateMap()
        {
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    Button button = new Button();
                    buttons[i, j] = button;
                    button.Size = new Size(sizeButton, sizeButton);
                    button.Text = map[i, j].ToString();
                    button.Click += OnCellPressed;
                    button.Location = new Point(j * sizeButton, i * sizeButton);
                    this.Controls.Add(button);
                }
            }
        }

    }


}
