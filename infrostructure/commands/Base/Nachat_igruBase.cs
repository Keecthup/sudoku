using System;
using System.Windows.Input;

namespace Sudoku.infrostructure.commands.Base
{
    internal abstract class CommandBase
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}