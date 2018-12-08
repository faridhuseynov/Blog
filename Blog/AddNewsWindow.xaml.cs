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
using System.Windows.Shapes;

namespace Blog
{
    /// <summary>
    /// Interaction logic for AddNewsWindow.xaml
    /// </summary>
    public partial class AddNewsWindow : Window
    {
        public AddNewsWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
        public NewsItem news;

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbHeader.Text)||string.IsNullOrWhiteSpace(tbText.Text))
                MessageBox.Show("Some data is missing, please check", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                news = new NewsItem{ Header = tbHeader.Text, ImageLink = tbImageLink.Text, Text = tbText.Text };
                Close();
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
