using System;
using System.Collections.Generic;
using System.Globalization;

namespace Task_4_2
{
    public class Dish
    {

        public string Name { get; set; }
        public int Mass { get; set; }
        public float Price { get; set; }
        public string[] Ingridients { get; set; }

        public Dish()
        {
            Name = NameInput();
            Mass = MassInput();
            Price = PriceInput();
            Ingridients = IngridientsInput();

        }


        private string NameInput()
        {
            Console.WriteLine("Введите название блюда");
            return Console.ReadLine();
        }

        private int MassInput()
        {
            Console.WriteLine("Укажите массу блюда в граммах");
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Масса указана в неправильном формате. Это должно быть целое число");
                return MassInput();
            }
        }

        private float PriceInput()
        {
            Console.WriteLine("Введите стоимость блюда в формате N.M где N рубли, а M копейки");
            try
            {
                return float.Parse((Console.ReadLine()), CultureInfo.InvariantCulture.NumberFormat);
            }
            catch (Exception)
            {
                Console.WriteLine("Стоимость указана в неправильном формате.");
                return PriceInput();
            }
        }

        private string[] IngridientsInput()
        {
            List<string> _innerList = new List<string>();
            bool isInputOn = true;
            while (isInputOn)
            {
                Console.WriteLine(" Введит ингридиент. Если вы ввели все ингридиенты введите - 0.");
                string userInput = Console.ReadLine();
                if (userInput == "0")
                {
                    isInputOn = false;
                    
                }
                else
                {
                    _innerList.Add(userInput);
                    Console.WriteLine("Текущий список ингридиентов");
                    foreach (string ingridient in _innerList)
                    {
                        Console.WriteLine($"- {ingridient}");
                    }
                }
            }
            return _innerList.ToArray();
        }

    }
}
        

   

    

