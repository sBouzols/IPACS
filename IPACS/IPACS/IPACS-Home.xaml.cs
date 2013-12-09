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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace IPACS
{
    /// <summary>
    /// Interaction logic for IPACS_Home.xaml
    /// </summary>
    public partial class IPACS_Home : Page
    {
        public IPACS_Home()
        {
            InitializeComponent();
        }

        private void image2_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OpenAbout_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow myAboutWindow = new AboutWindow();
            myAboutWindow.Show();
        }
        

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                image1.Source = new BitmapImage(new Uri(op.FileName));
                image2.Source = new BitmapImage(new Uri(op.FileName));
                LabelLeft.Content = op.FileName;
                LabelRight.Content = op.FileName;
            }
        }
    }
}
