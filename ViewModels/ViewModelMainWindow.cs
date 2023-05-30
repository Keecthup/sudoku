using sudoku.Models;
using sudoku.ViewModels.basa;
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

namespace sudoku.ViewModels
{
    internal class ViewModelMainWindow : ViewModel
    {
        private Board board = new();

        private ICommand? newGameCommand;
        public Board Board
        {
            get => board;
            set
            {
                board = value;
                OnPropertyChanged();
            }
        }
        public ICommand NewGameCommand => newGameCommand ??= new RelayCommand(parameter =>
        {
            SetupBoard();
        });
        private void SetupBoard()
        {
            Board board = new();
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    Board [i, j] = 
                    Board = board;
                }
        }
        

       


    }


}
