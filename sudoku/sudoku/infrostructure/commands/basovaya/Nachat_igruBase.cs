using System;
using System.Windows.Input;

namespace sudoku.infrostructure.commands.basovaya
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