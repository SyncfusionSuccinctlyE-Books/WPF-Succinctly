using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFExample
{
    /// <summary>
    /// Interaction logic for ButtonClick.xaml
    /// </summary>
    public partial class ButtonClick : Window
    {
        public ButtonClick()
        {
            InitializeComponent();
        }

        private void btnFireEvent_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello Event Handler!");
        }
    }
}
