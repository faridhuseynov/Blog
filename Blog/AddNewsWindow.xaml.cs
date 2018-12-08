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

        }
        public NewsItem news;
        private string newsHeader;
        public string NewsHeader
        {
            get => newsHeader;
            set => Set(ref newsHeader, value);
        }

        private string imageLink;
        public string ImageLink
        {
            get => imageLink;
            set => Set(ref imageLink, value);
        }

    }
}
