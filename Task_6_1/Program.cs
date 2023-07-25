/* 6
 * Разработать класс NewsProvider, предоставляющий услуги рассылки информации по категориям (новости, погода, спорт, происшествия, юмор).
 * Разработать класс Client, который подписывается на определенную категорию и при выходе новой новости в выбранной категории выводит в консоль сообщение о том, что получил эту новость.
 * 
 * В основной программе создать экземпляры классов источника и подписчик(а/ов), привязывая подписчика к источнику и категории новости через конструктор подписчика.
 * 
 * Можно пользоваться делегатами напрямую. Круче — воспользоваться стандартной обёрткой EventHandler<T>.*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_6_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Client> clientsList = new List<Client>()
            {
            new Client("Ольк", "olk@gmail.com", NewsTypes.Погода),
            new Client("Дмитрий Петрович", "dim@pe.tr", NewsTypes.Юмор),
            new Client("Женя", "телега", NewsTypes.Спорт)
            };

            List<NewsProvider> newsList = new List<NewsProvider>()
            {
            new NewsProvider("Котик перевернулся на другой бочок", NewsTypes.Новости),
            new NewsProvider("На улице было солнечно и ящерки грелись на камушках", NewsTypes.Погода),
            new NewsProvider("Счастливый псо помешал проведению футбольного матча в Англии украв мяч", NewsTypes.Спорт),
            new NewsProvider("Выдрочка скушала много лосося и довольна", NewsTypes.Происшествия),
            new NewsProvider("Звезда тиктока Кот Степан делает :3 ", NewsTypes.Юмор),
            new NewsProvider("Кабанчики случайно выиграли велогонку во Франции", NewsTypes.Спорт),
            new NewsProvider("Попугай научился говорить \"ну шо там?\" и был повышен до проджект менеджера", NewsTypes.Новости)
            };

            foreach (Client client in clientsList)
            {
                client.Notify += DisplayMessage;
                foreach (NewsProvider news in newsList)
                {
                    if (news.NewsType == client.ClientNewsTypes)
                    {
                        news.SendNews(client);
                        client.PushNotify();
                    }
                }
            }

            void DisplayMessage(string message) => Console.WriteLine(message);

        }
    }
}
