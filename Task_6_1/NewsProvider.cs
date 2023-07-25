using System;
using System.Linq;

namespace Task_6_1
{
    public class NewsProvider
    {
        public string NewsTitle;
        public NewsTypes NewsType; 

        public NewsProvider(string newsTitle, NewsTypes newsType)
        {
            NewsTitle = newsTitle;
            NewsType = newsType;
            //ShowNewsMetaOnCreation();
        }

        private void ShowNewsMetaOnCreation()
        {
            Console.WriteLine($"Создана новость {this.NewsTitle} типа {NewsType}");
        }


        public void SendNews(Client client)
        {
            if (client.ClientNewsTypes == this.NewsType)
            {
                Console.WriteLine($"Отправлена новость \"{this.NewsTitle}\" типа {NewsType} пользователю {client.ClientName}");
                
            }
        }

    }

    public enum NewsTypes {Новости, Погода, Спорт, Происшествия, Юмор }
}
