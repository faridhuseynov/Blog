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
            Feed.Add(new NewsItem { Header = "Life after 50", Text = "This guy is looser", ImageLink = "https://img.day.az/2018/12/09/400x275/parkur_gym_091218_3.jpg" });
        }


        private RelayCommand newsAdd;
        public RelayCommand NewsAdd
        {
            get => newsAdd ?? (newsAdd = new RelayCommand(
                 param =>
                  {
                      AddNewsWindow window = new AddNewsWindow();
                      window.ShowDialog();
                      if (window.news != null)
                      {
                          Feed.Add(window.news);
                      }
                  }
                 ));
        }
        
        private RelayCommand readNews;
        public RelayCommand ReadNews
        {
            get => readNews ?? (readNews = new RelayCommand(
                 param =>
                 {
                     var news = param as NewsItem;
                     var window = new ReadNewsWindow();
                     window.News = news;
                     window.ShowDialog();
                 }
                 ));
        }

        private RelayCommand deleteNews;
        public RelayCommand DeleteNews
        {
            get => deleteNews ?? (deleteNews = new RelayCommand(
                 param =>
                 {
                     var news = param as NewsItem;
                     Feed.Remove(news);
                 }
                 ));
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
