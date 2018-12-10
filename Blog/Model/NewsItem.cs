using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class NewsItem:ObservableObject
    {
        public int Id { get; set; }

        private string header;
        public string Header
        {
            get =>  header;
            set => Set(ref header, value);
        }

        private string text;
        public string Text
        {
            get => text;
            set => Set(ref text, value);
        }


        private string imageLink;
        public string ImageLink
        {
            get => imageLink;
            set => Set(ref imageLink, value);
        }

    }
}
