using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace WPFCommand
{
    public class ButtonClickCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            var viewModel = (CommandViewModel)parameter;

            viewModel.ShowMessagebox("Hello decoupled command!");
        }
    }
}
