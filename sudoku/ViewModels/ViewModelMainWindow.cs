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
        private string _Title = "Судоку";
        private string _title;
        public string Title
        {
            get { return _title; }
            set{ _title = value; }
        }
    }
}
