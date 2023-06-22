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
            Console.WriteLine("Введите 6 чисел через пробел");
            string stringOfNumbers = Console.ReadLine();
            string[] numbers = stringOfNumbers.Split(' ');
            int i = 0;
            foreach (string number in numbers)
            {
                
                int result = Convert.ToInt32(number);
                userNumbers[i] = result;
                Console.WriteLine(userNumbers);
                i += 1;

            }
            
        }
    }
}
