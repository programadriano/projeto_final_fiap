using API.Entities;
using API.Entities.ViewModels;
using API.Infra;

namespace API.Services
{
    public class NewsService
    {
        private readonly IRepository<News> _news;

        public NewsService(IRepository<News> news)
        {
            _news = news;
        }

        public Result<News> Get(int page, int qtd) => _news.Get(page, qtd);

        public News Get(string id) => _news.Get(id);

        public News Create(NewsViewModel news)
        {
            var entity = new News(news.Title, news.Hat, news.Description, news.CreatedBy, news.Tags, news.Status);

            _news.Create(entity);

            return Get(entity.Id);
        }

        public void Update(string id, NewsViewModel news)
        {
            var entity = new News(news.Title, news.Hat, news.Description, news.CreatedBy, news.Tags, news.Status);
            _news.Update(id, entity);

        }

        public void Remove(string id)
        {            
            _news.Remove(id);
        }



    }
}
