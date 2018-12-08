using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class MainWindowViewModel
    {
        public ObservableCollection<NewsItem> Blog { get; set; }
    }
}
