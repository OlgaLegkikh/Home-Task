/* 6
 * Разработать класс NewsProvider, предоставляющий услуги рассылки информации по категориям (новости, погода, спорт, происшествия, юмор).
 * Разработать класс Client, который подписывается на определенную категорию и при выходе новой новости в выбранной категории выводит в консоль сообщение о том, что получил эту новость.
 * 
 * В основной программе создать экземпляры классов источника и подписчик(а/ов), привязывая подписчика к источнику и категории новости через конструктор подписчика.
 * 
 * Можно пользоваться делегатами напрямую. Круче — воспользоваться стандартной обёрткой EventHandler<T>.*/

using System;
using System.Collections.Generic;


namespace Task_6_1
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            var newsProvider1 = new NewsProvider(NewsTypes.Новости);
            var newsProvider2 = new NewsProvider(NewsTypes. Спорт);
            var client1 = new Client("Ольк", "olk@gmail.com", newsProvider1);
            var client2 = new Client("Дмитрий Петрович", "какой-то имейл", newsProvider2);
            var provider = new Provider();
            provider.Main();

            provider.SubscribeOnNews(client1);
            provider.SubscribeOnNews(client2);




            List<News> newsList = new List<News>()
            {
            new News("Котик перевернулся на другой бочок", NewsTypes.Новости),
            new News("На улице было солнечно и ящерки грелись на камушках", NewsTypes.Погода),
            new News("Счастливый псо помешал проведению футбольного матча в Англии украв мяч", NewsTypes.Спорт),
            new News("Выдрочка скушала много лосося и довольна", NewsTypes.Происшествия),
            new News("Звезда тиктока Кот Степан делает :3 ", NewsTypes.Юмор),
            new News("Кабанчики случайно выиграли велогонку во Франции", NewsTypes.Спорт),
            new News("Попугай научился говорить \"ну шо там?\" и был повышен до проджект менеджера", NewsTypes.Новости)
            };
            foreach (News news in newsList)
            {
                provider.SendNewsToCurrentTypeProvider(news);
            }
        }
    }

    

}
