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
        private NewsRepository db = new NewsRepository();
        private ObservableCollection<NewsItem> feed;
        public ObservableCollection<NewsItem> Feed
        {
            get => feed;
            set => Set(ref feed, value);
        }

        public MainWindowViewModel()
        {
            Feed= new ObservableCollection<NewsItem>(db.List());
            //Feed.Add(new NewsItem { Header = "Life after 50", Text = "This guy is looser", ImageLink = "https://img.day.az/2018/12/09/400x275/parkur_gym_091218_3.jpg" });
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
                          db.Add(window.news);
                          Feed = new ObservableCollection<NewsItem>(db.List());
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
                     window.Title = news.Header;
                     window.News = news;
                     window.ShowDialog();
                 }
                 ));
        }

        private RelayCommand editNews;
        public RelayCommand EditNews
        {
            get => editNews ?? (editNews = new RelayCommand(
                 param =>
                 {
                     var news = param as NewsItem;
                     var window = new NewsEditWindow();
                     window.Title = news.Header;
                     window.News = news;
                     window.ShowDialog();
                     db.Edit(news.Id,news);
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
                     db.Delete(news.Id);
                     Feed = new ObservableCollection<NewsItem>(db.List());
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
