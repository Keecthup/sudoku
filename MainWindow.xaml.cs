using sudoku.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sudoku
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TextBlock[,] sudokuTextBlocks;
        private ViewModelMainWindow? sudoku;

        public MainWindow()
        {
            InitializeComponent();
            GenerateSudokuGrid();
        }
        private void NewGame(object sender, EventArgs args)
        {
            sudoku = new ViewModelMainWindow();
            sudoku.GenerateSudoku();
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    sudokuTextBlocks[i, j].SetBinding(TextBlock.TextProperty, new Binding($"Board[{i}][{j}]"));
            DataContext = sudoku;
        }
        private void GenerateSudokuGrid()
        {
            sudokuTextBlocks = new TextBlock[9, 9];
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    var border = new Border
                    {
                        BorderBrush = Brushes.Black,
                        BorderThickness = GetThickness(i, j, 0.1, 0.3)
                    };
                    sudokuTextBlocks[i, j] = new TextBlock
                    {
                        FontSize = 5,
                        VerticalAlignment = VerticalAlignment.Center,
                        HorizontalAlignment = HorizontalAlignment.Center
                    };
                    border.Child = sudokuTextBlocks[i, j];
                    Grid.SetRow(border, i);
                    Grid.SetColumn(border, j);
                    SudokuGrid.Children.Add(border);
                }
        }
        private Thickness GetThickness(int i, int j, double thin, double thick)
        {
            var top = i % 3 == 0 ? thick : thin;
            var bottom = i % 3 == 2 ? thick : thin;
            var left = j % 3 == 0 ? thick : thin;
            var right = j % 3 == 2 ? thick : thin;
            return new Thickness(left, top, right, bottom);
        }

    }
}
