using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.Data;
using System.Data.Entity;

namespace ITI.Repository.Repository
{
    public class NewsRepository
    {
        protected ITIDataEntities iTIDataEntities;
        public NewsRepository()
        {
            iTIDataEntities = new ITIDataEntities();
        }
        public List<NewsTable> GetNews()
        {
            return iTIDataEntities.NewsTables.ToList();
        }
        public NewsTable GetNewsById(int id)
        {
            return iTIDataEntities.NewsTables.FirstOrDefault(x => x.ID == id);
        }
        public NewsTable InsertNews(NewsTable newsTable)
        {
            var inserted = iTIDataEntities.NewsTables.Add(newsTable);
            iTIDataEntities.SaveChanges();
            return inserted;
        }
        public NewsTable UpdateNews(NewsTable newsTable)
        {
            iTIDataEntities.Entry(newsTable).State = EntityState.Modified;
            iTIDataEntities.SaveChanges();
            return newsTable;
        }
        public void DeleteNews(int id)
        {
            var news = iTIDataEntities.NewsTables.FirstOrDefault(x => x.ID == id);
            iTIDataEntities.NewsTables.Remove(news);
            iTIDataEntities.SaveChanges();
        }
    }
}
