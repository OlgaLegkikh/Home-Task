using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_4_2
{
    public class DishesCollection<T> : IList<T> where T : Dish
    {
        private List<Dish> _innerList = new List<Dish>();
        private DishesComparer _comparer = new DishesComparer();

        public T this[int index]
        {
            get => (T)_innerList[index];
            set => _innerList[index] = value;
        }

        public void OutputDishesToConsole()
        {
            var builder = new StringBuilder();

            foreach (var currentObject in _innerList)
            {
                builder.Append(currentObject.Name);
                builder.Append(Environment.NewLine);
                builder.Append($"{currentObject.Mass} грамм");
                builder.Append(Environment.NewLine);
                builder.Append($"{currentObject.Price} руб.");
                builder.Append(Environment.NewLine);
                builder.Append("Состав:");
                builder.Append(Environment.NewLine);
                foreach (string ingridient in currentObject.Ingridients)
                {
                    builder.Append($" - {ingridient}");
                    builder.Append(Environment.NewLine);
                };
                builder.Append(Environment.NewLine);



            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Меню:");
            Console.WriteLine(builder);
        }
        
        public void SortByPrice()
        {
            _innerList.Sort(new DishesComparer());
            Console.WriteLine("Блюда отсортированы по цене!");
        }
        public int Count => _innerList.Count();

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            _innerList.Add(item);
            Console.WriteLine($"Добавлено новое блюдо \"{item.Name}\"!");
            SortByPrice();
            OutputDishesToConsole();
        }

        public void Clear()
        {
            _innerList.Clear();
            Console.WriteLine("Меню очищено!");
        }

        public bool Contains(T item)
        {
            if (_innerList.Contains(item))
            {
                Console.WriteLine($"Да, позиция \"{item.Name}\" есть в меню");
                return true;
            }
            else
            {
                Console.WriteLine($"Увы, позиции \"{item.Name}\" нет в меню");
                return false;
            }

        }


        public void CopyTo(T[] array, int arrayIndex)
        {
            _innerList.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            var enumerator = _innerList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                yield return (T)enumerator.Current;
            }
        }


        public int IndexOf(T item) => _innerList.IndexOf(item);


        public void Insert(int index, T item)
        {
            _innerList.Insert(index, item);
            Console.WriteLine($"Блюдо \"{item.Name}\" добавлено в меню на позицию № {index + 1}!");
            OutputDishesToConsole();
        }

        public bool Remove(T item)
        {
            if (_innerList.Remove(item))
            {
                Console.WriteLine($"Блюдо \"{item.Name}\" удалено из меню!");
                OutputDishesToConsole();
                return true;
            }
            else
            {
                Console.WriteLine($"Блюдо \"{item.Name}\" не найдено в меню");
                return false;
            }

        }

        public void RemoveAt(int index)
        {
            Console.WriteLine($"Блюдо \"{_innerList[index].Name}\" удалено из меню!");
            _innerList.RemoveAt(index);
            OutputDishesToConsole();

        }

        IEnumerator IEnumerable.GetEnumerator() => _innerList.GetEnumerator();

    }
}
