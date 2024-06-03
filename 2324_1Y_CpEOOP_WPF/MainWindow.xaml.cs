using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2324_1Y_CpEOOP_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int textLength = 100;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSample_Click(object sender, RoutedEventArgs e)
        {
            if (txtbSample.Text.Length > 0)
            {
                MessageBox.Show($"{txtbSample.Text} loves Krizan", "Krizan"
                    , MessageBoxButton.YesNo, MessageBoxImage.Warning);

                lblSamples.Content += txtbSample.Text;
                txtbSample.Text = "";
            }
            else
                MessageBox.Show($"Jet loves Krizan", "Krizan"
                    , MessageBoxButton.YesNo, MessageBoxImage.Warning);
        }

        private void txtbSample_TextChanged(object sender, TextChangedEventArgs e)
        {
            string temp = txtbSample.Text;
            if(temp.Length > textLength)
            {
                temp = temp.Substring(0, textLength);
                txtbSample.Text = temp;
            }
        }

        private void btnNextPage_Click(object sender, RoutedEventArgs e)
        {
            WindowManager.w1_status(true);
        }
    }
}
