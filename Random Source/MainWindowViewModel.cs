using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace WPFMVVMValidation
{
    class MainWindowViewModel : ObservableCollection<Product>
    {
        public MainWindowViewModel()
        {
            Add(new Product { TotalAmount = 3 });
        }
    }
}
