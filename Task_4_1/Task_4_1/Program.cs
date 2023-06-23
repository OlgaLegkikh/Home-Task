/*- Создайте 2 списка. Первый типа ArrayList и второй List<T> - где «T» будет любым из базовых типов по вашему выбору.
- Добавьте в каждый из списко 2 новых элемента. 
- Удалите элемент с индексом 3.
- Удалите из списка 1 добавленный вами элемент.
- Отсорируйте полученный список.
- После каждого изменения списка выводите его на экран.
*/

using System;
using System.Collections.Generic;
using System.Collections;

namespace Task_4_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {



            List<String> games = new List<String>
            {
                "Disco Elysium",
                "Hollow Knight",
                "Life is Strange",
                "Civilization III",
                "Heroes of Might and Magic IV",
                "Understand"
            };

            var shoppingList = new ArrayList()
            {
                "milk",
                "honey",
                "bread",
                "cheese",
                "ice-creame"
            };

            listOutput(games, shoppingList, "1) Cоздание списков");

            games.Add("Resident Evil");
            games.Add("Zelda: Ocarina of Time");

            shoppingList.Add("water");
            shoppingList.Add("T-shirt");

            listOutput(games, shoppingList, "2) Добавление 2 элементов в список");

            games.RemoveAt(3);
            shoppingList.RemoveAt(3);

            listOutput(games, shoppingList, "3) Удаление элемента с индексом 3");

            games.Sort();
            shoppingList.Sort();

            listOutput(games, shoppingList, "4) Сортировка списка");

            void listOutput(List<String> list1, ArrayList arrlist, string action)
            {
                Console.WriteLine(action);
                Console.WriteLine($"Список игр(List<T>): {string.Join(", ", list1)}");
                Console.Write("Список покупок(ArrayList): ");
                foreach (string item in arrlist)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine(Environment.NewLine);

            }
        }
    }
}
