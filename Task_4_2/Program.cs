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
            var Borsch = new Dish
            {
                Name = "Борщ",
                Mass = 500,
                Ingridients = new string[] { "Бульон", "Свекла", "Мамина любовь", "Помидорки" },
                Price = 0f
            };

            Menu.Add(Borsch);
            Menu.Clear();

            var snaсk = new Dish
            {
                Name = "Чипсы",
                Mass = 200,
                Price = 4f,
                Ingridients = new string[] { "Картошечка", "Маслице" }
            };

            Menu.Add(new Dish
            {
                Name = "Омлет с грибами",
                Mass = 200,
                Price = 5.5f,
                Ingridients = new string[] { "Яйца", "Шампиньоны", "Сыр", "Молоко" }

            });

            Menu.Add(new Dish
            {
                Name = "Шакшука",
                Mass = 250,
                Price = 10.5f,
                Ingridients = new string[] { "Яйца", "Болгарский перец", "Пшеничная лепешка", "Помидоры", "Чеснок"}

            });

            Menu.Add(new Dish
            {
                Name = "Гранола",
                Mass = 250,
                Price = 5.5f,
                Ingridients = new string[] { "Овсянка", "Орехи", "Молоко", " Мед", "Корица" }

            });

            Menu.Insert(0, new Dish {
                Name = "Тост с авокадо",
                Mass = 120,
                Price = 3.2f,
                Ingridients = new string[] {"Авокадо", "Цельнозерновой хлеб", "Лимон", "Яйцо"}
            });

            Menu.Remove(Borsch);
            Menu.Contains(snaсk);
            Menu.Add(snaсk);
            Menu.Contains(snaсk);
            Menu.RemoveAt(Menu.IndexOf(snaсk));


        }
    }
}
