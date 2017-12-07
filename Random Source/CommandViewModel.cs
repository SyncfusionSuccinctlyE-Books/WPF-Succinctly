using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows;

namespace WPFCommand
{
    public class CommandViewModel 
    {
        public ICommand ButtonClickCommand
        {
            get
            {
                return new ButtonClickCommand();
            }
        }

        public void ShowMessagebox(string message)
        {
            MessageBox.Show(message);
        }
    }
}
