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
    /// Interaction logic for ReadNewsWindow.xaml
    /// </summary>
    public partial class ReadNewsWindow : Window
    {
        public ReadNewsWindow(object parameter)
        {
            InitializeComponent();
            DataContext = this;
            var News=parameter as NewsItem;
            
        }
        
    }
}
