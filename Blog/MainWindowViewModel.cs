using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class MainWindowViewModel:ObservableObject
    {
        private ObservableCollection<NewsItem> feed=new ObservableCollection<NewsItem>();
        public ObservableCollection<NewsItem> Feed
        {
            get => feed;
            set => Set(ref feed, value);
        }

        public MainWindowViewModel()
        {
            Feed.Add(new NewsItem { Header = "Hello", Text = "aa", ImageLink = @"C:\Users\Huse_fr93\source\repos\Blog.jpeg" });
        }


        //private RelayCommand addNews;
        //public RelayCommand AddNews
        //{
        //    get => addNews ?? (addNews = new RelayCommand(
        //         param =>
        //         {
        //             var news = new AddNewsWindow();

        //             var task = param as ToDoItem;
        //             db.Edit(task.Id);
        //             Items = new ObservableCollection<ToDoItem>(db.List());
        //             //task.IsDone = !task.IsDone;
        //         }
        //         ));
        //}
    }
}
