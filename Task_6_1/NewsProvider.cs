using System;
using System.Linq;



namespace Task_6_1
{
    public delegate void SendNewsDelegate(News news);

    public class News
    {
        public NewsTypes Type;
        public string Title;

        public News(string title,NewsTypes type)
        {
            Type = type;
            Title = title;
        }
    }

    public class NewsProvider
    {
        public NewsTypes Type;
        public event SendNewsDelegate NewsDelegate;


        public NewsProvider(NewsTypes newsType)
        {
     
            Type = newsType;
            
        }


        public void SendNews(News news)
        {
            Console.WriteLine($"Отправлена новость {news.Title} типа {news.Type}");
            NewsDelegate?.Invoke(news);

        }

    }

    public enum NewsTypes {Новости, Погода, Спорт, Происшествия, Юмор }
}
