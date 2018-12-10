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
    /// Interaction logic for NewsEditWindow.xaml
    /// </summary>
    public partial class NewsEditWindow : Window
    {
        public NewsItem News { get; set; }               

        public NewsEditWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbHeader.Text))
                MessageBox.Show("News header is missing, please fill in", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (string.IsNullOrWhiteSpace(tbText.Text))
                MessageBox.Show("News text is missing, please fill in", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                //this is being done, because updatesourcetrigger set for Explicit, which means we manually perform
                //updates after checking that everything is OK

                //header box update
                tbHeader.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                

                //ImageLinkBox update
                tbImageLink.GetBindingExpression(TextBox.TextProperty).UpdateSource();

                //image source update
                imageBox.GetBindingExpression(Image.SourceProperty).UpdateSource();

                //textbox update
                tbText.GetBindingExpression(TextBox.TextProperty).UpdateSource();

                Close();
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
                Close();
        }
    }
}
