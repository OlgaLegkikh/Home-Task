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
            new Client("Ольк", "olk@gmail.com", new int[] { 2, 4 }),
            new Client("Дмитрий Петрович", "dim@pe.tr", new int[] { 0, 3 }),
            new Client("Женя", "телега", new int[] { 1 })
            };

            List<NewsProvider> newsList = new List<NewsProvider>()
            {
            new NewsProvider("Котик перевернулся на другой бочок", 0),
            new NewsProvider("На улице было солнечно и ящерки грелись на камушках", 3),
            new NewsProvider("Счастливый псо помешал проведению футбольного матча в Англии украв мяч", 2),
            new NewsProvider("Выдрочка скушала много лосося и довольна", 3),
            new NewsProvider("Звезда тиктока Кот Степан делает :3 ", 4),
            new NewsProvider("Кабанчики случайно выиграли велогонку во Франции", 2),
            new NewsProvider("Попугай научился говорить \"ну шо там?\" и был повышен до проджект менеджера", 0)
            };

            foreach (Client client in clientsList)
            {
                client.Notify += DisplayMessage;
                foreach (NewsProvider news in newsList)
                {
                    if (client.ClientNewsTypes.Contains(news.NewsTypeId))
                    {
                        news.SendNews(client);
                    }
                }
            }

            void DisplayMessage(string message) => Console.WriteLine(message);

        }
    }
}
