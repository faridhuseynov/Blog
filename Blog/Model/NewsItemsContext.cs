using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Model
{
    class NewsItemsContext:DbContext
    {
        public NewsItemsContext() : base("DefaultConnection") { }

        public DbSet<NewsItem> News { get; set; }
    }
}
