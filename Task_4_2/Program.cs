/* 
 * Создайте пользовательский список — список, содержащий объекты определённого Вами типа, наследующийся от Collection<T>.
 * Реализуйте добавление в список нового объекта так, чтобы после добавления список сортировался по одному из свойств вашего класса.
 * Заполните список начальными данными.
 * Добавьте в ваш список новый элемент.
 * После каждого изменения списка выводите его на экран
*/
using System;
using System.Collections.ObjectModel;

namespace Task_4_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var Menu = new DishesCollection<Dish>();
            bool isMenuCreationOn = true;
            while (isMenuCreationOn)
            {
                
Console.WriteLine(@"
Выберите команду:
1 - Показать меню
2 - Отсортировать меню по стоимости
3 - Добавить блюдо и отсортировать меню по стоимости
4 - Добавить блюдо на определенную позицию
5 - Очистить меню
6 - Удалить блюдо на определенной позиции
7 - Проверить есть ли в меню такое блюдо
0 - Выйти из создания меню
");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        {
                            Console.WriteLine("До встречи!");
                            isMenuCreationOn = false;
                            break;
                        }
                    case "1":
                        {
                            Menu.OutputDishesToConsole();
                            break;
                        }
                    case "2":
                        {
                            Menu.SortByPrice();
                            break;
                        }
                    case "3":
                        {
                            Menu.Add(new Dish());
                            Menu.SortByPrice();
                            break;
                        }
                    case "4":
                        {
                            Menu.Insert(DishPositionInput() - 1, new Dish());
                            break;
                        }
                    case "5":
                        {
                            Menu.Clear();
                            break;
                        }
                    case "6":
                        {
                            Menu.RemoveAt(DishPositionInput() - 1);
                            break;
                        }
                    case "7":
                        {
                            Menu.Contains(new Dish());
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Мне не известна такая команда");
                            break;
                        }
                }

            }

            int DishPositionInput() {
                Console.WriteLine("Введите позицию");
                string dishPositionStr = Console.ReadLine();
                int dishPositionInt;
                try
                {
                    dishPositionInt = Convert.ToInt32(dishPositionStr);
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Позиция указана в невереном формате");
                    return DishPositionInput();
                }
                
                return dishPositionInt;
                }



        }
    }
}
