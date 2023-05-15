using sudoku.ViewModels.basa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace sudoku.ViewModels
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

        private void OnCloseApplicationCommandExecute(object sender, ExecutedRoutedEventArgs e) {
        
        }
        private bool CanCloseApplicationCommandExecute(object sender, ExecutedRoutedEventArgs e) => true;
        #endregion
        #endregion
        public ViewModelMainWindow()
        {
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecute, CanCloseApplicationCommandExecute);

        }
    }

    
}
