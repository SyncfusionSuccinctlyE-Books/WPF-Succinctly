using System.Windows;
using System.Windows.Media;

namespace Chapter01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetRenderingTier_Click(object sender, RoutedEventArgs e)
        {
            //Shift the value 16 bits to retrieve the rendering tier
            int currentRenderingTier = (RenderCapability.Tier >> 16);

            switch (currentRenderingTier)
            {
                //DirectX version level less than 7.0
                case 0:
                    txtRenderingTier.Text = string.Format("{0} No hardware acceleration.", currentRenderingTier.ToString());        
                    break;
                //DirectX version level greater 7.0 but less than 9.0
                case 1:
                    txtRenderingTier.Text = string.Format("{0} Partial hardware acceleration.", currentRenderingTier.ToString());
                    break;
                //DirectX version level greater than or equal to 9.0 
                case 2:
                    txtRenderingTier.Text = string.Format("{0} Total hardware acceleration.", currentRenderingTier.ToString());
                    break;
            }
        }
    }
}
