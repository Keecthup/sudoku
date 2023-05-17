using Sudoku.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Windows.Controls;

namespace Sudoku.ViewModels
{
    internal class ViewModelMainWindow : ViewModel
    {
#region Tittle
        private string _Title = "Судоку";
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }
        #endregion
        #region Команды
        #region Close
        
        public ICommand CloseApplicationCommand { get;}

        private void OnCloseApplicationCommandExecute(object? p) {
            Application.Current.Shutdown();
                }
        private bool CanCloseApplicationCommandExecute(object? p) => true;
        #endregion
        #endregion
        public ViewModelMainWindow()
        {
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecute, CanCloseApplicationCommandExecute);
        }
    }

    
}
