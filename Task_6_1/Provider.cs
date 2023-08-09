using System;
using System.Collections.Generic;

namespace Task_6_1
{
    public class Provider
    {
        private Dictionary<NewsTypes, NewsProvider> _providers;

        public void Main()
        {
            _providers = new Dictionary<NewsTypes, NewsProvider>();
            foreach (NewsTypes type in Enum.GetValues(typeof(NewsTypes)))
            {
                var provider = new NewsProvider(type);
                _providers.Add(type, provider);
            }
        }

        public void SendNewsToCurrentTypeProvider(NewsTypes type, string newsTitle)
        {
            var news = new News(newsTitle, type);
            _providers[news.Type].SendNews(news);
        }

        public void SendNewsToCurrentTypeProvider(News news)
        {
            _providers[news.Type].SendNews(news);
        }



        public void SubscribeOnNews(Client client)
        {
            _providers[client.Type].NewsDelegate += client.RecieveNews;
        }
    }
}

