using sudoku.infrostructure.commands.basovaya;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sudoku.ViewModels
{
    internal class LambdaCommand : Nachat_igru
    {
        public LambdaCommand(Action<object?> Execute, Func<object?, bool> CanExecute) 
        {
            _Execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            _CanExecute = CanExecute;
        }

        private readonly Action<object?> _Execute;
        private readonly Func<object?, bool> _CanExecute;


        public override bool CanExecute(object? parameter) => _CanExecute?.Invoke(parameter) ?? true;
        public override void Execute(object? parameter) =>  _Execute(parameter);
        
    }
}
