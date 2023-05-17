using System;
using System.Windows.Input;

namespace Sudoku.infrostructure.commands.Base
{
    internal abstract class Nachat_igruBase
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}