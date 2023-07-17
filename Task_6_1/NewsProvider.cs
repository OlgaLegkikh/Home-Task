using System;
using System.Linq;

namespace Task_6_1
{
    public class NewsProvider
    {
        public string NewsTitle;
        public int NewsTypeId;
        private string[] _newsTypes = {"новости", "погода", "спорт", "происшествия", "юмор"};

        public NewsProvider(string newsTitle, int newsTypeId)
        {
            NewsTitle = newsTitle;
            NewsTypeId = newsTypeId;
            //ShowNewsMetaOnCreation();
        }

        private void ShowNewsMetaOnCreation()
        {
            Console.WriteLine($"Создана новость {this.NewsTitle} типа {this._newsTypes[NewsTypeId]}");
        }


        public void SendNews(Client client)
        {
            if (client.ClientNewsTypes.Contains(this.NewsTypeId))
            {
                Console.WriteLine($"Отправлена новость \"{this.NewsTitle}\" пользователю {client.ClientName}");
                client.RecieveEmail();
            }
        }

    }
}
