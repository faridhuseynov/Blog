using Blog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class NewsRepository
    {
        public void Add(NewsItem news)
        {
            using (var db = new NewsItemsContext())
            {
                db.News.Add(news);
                db.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (var db = new NewsItemsContext())
            {
                var deleted = db.News.Where(x => x.Id == Id).FirstOrDefault();
                db.News.Remove(deleted);
                db.SaveChanges();
            }
        }

        public void Edit(int Id, NewsItem item)
        {
            using (var db = new NewsItemsContext())
            {
                var changed = db.News.Where(x => x.Id == Id).FirstOrDefault();
                changed.Header = item.Header;
                changed.ImageLink = item.ImageLink;
                changed.Text = item.Text;
                db.SaveChanges();
            }
        }

        public IEnumerable<NewsItem> List()
        {
            using(var db=new NewsItemsContext())
            {
                return db.News.ToList();
            }
        }
    }
}
