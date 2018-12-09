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
            Feed.Add(new NewsItem { Header = "Hello", Text = "aa", ImageLink = "https://img.day.az/2018/12/09/400x275/parkur_gym_091218_3.jpg" });
        }

        private NewsItem selectedNews;
        public NewsItem SelectedNews
        {
            get => selectedNews;
            set => Set(ref selectedNews, value);
        }


        private RelayCommand readNews;
        public RelayCommand ReadNews
        {
            get => readNews ?? (readNews = new RelayCommand(
                 param =>
                 {
                     var window = new ReadNewsWindow(SelectedNews);
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
                     Feed.Remove(SelectedNews);
                 },
                 param => SelectedNews != null
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
