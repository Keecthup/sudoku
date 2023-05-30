using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sudoku.ViewModels.basa;

namespace sudoku.Models
{
    public class Cell : ViewModel
    {
        private bool act;
        private int row;
        private int column;
        private Board? board;


        public bool Act
        {
            get => act;
            set
            {
                act = value;
                OnPropertyChanged();
            }
        }

        public int Row
        {
            get => row;
            set
            {
                row = value;
                OnPropertyChanged();
            }
        }

        public int Column
        {
            get => column;
            set
            {
                column = value;
                OnPropertyChanged();
            }
        }

        public Board Board
        {
            get => board!;
            set
            {
                board = value;
                OnPropertyChanged();
            }
        }

        public Cell(int row, int column, Board board)
        {
            Row = row;
            Column = column;
            Board = board;
        }
    }

}
