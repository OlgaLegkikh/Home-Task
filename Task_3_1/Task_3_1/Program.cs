/*- Объявить и проинициализировать массив int[] на 6 элементов.
- Ввести значения элементов массива из консоли.
- Вывести введенные отсортированные по убыванию элементы массива на экран.
*/

using System;

namespace Task_3_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] userNumbers = new int[6];
            
            for (int number = 0; number < userNumbers.Length; number++)
            {
                Console.WriteLine("Введите число");
                userNumbers.SetValue(Convert.ToInt32(Console.ReadLine()), number);
            }


            Array.Sort(userNumbers);
            Array.Reverse(userNumbers);
            Console.WriteLine($"{Environment.NewLine}Ваши числа отсортированы");

            foreach (int number in userNumbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
