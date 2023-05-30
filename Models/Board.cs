using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudoku.Models
{
    public class Board 
    {
        private readonly Cell[][] area;

        public Solution this [int row]
        { 
        
            get => area[row] [9].Solution;
            set => area[row] [9].Solution = value;
        
           }
    public Board()
        {
            area = new Cell[9, 9];
            for (int i = 0; i < area.GetLength(0); i++)
            {
                for (int j = 0; j < area.GetLength(1); j++)
                {
                    area[i, j] = new Cell(i, j, this);
                }
            }
        }


    }
}
