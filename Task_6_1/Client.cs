using System;
using System.Collections.Generic;

namespace Task_6_1
{
    public class Client
    {

        public string ClientName;
        public string ClientEmail;
        public NewsTypes Type;

        public Client(string clientName, string clientEmail, NewsProvider provider)
        {
            provider.NewsDelegate += RecieveNews;
            ClientName = clientName;
            ClientEmail = clientEmail;
            Type = provider.Type;
        }

            public void RecieveNews(News news)
            {

                if (news.Type == Type)
                {
                    Console.WriteLine($"{ClientName}, получена новость \"{news.Title}\"!");
                }

            }
 

    }
}