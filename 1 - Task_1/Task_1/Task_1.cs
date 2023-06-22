/*Task 1 Descreption С помощью цикла со счетчиком вывести на экран 
 * в одну строку все двузначные числа, кратные 5.
*/
using System;

namespace Task_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string solution = "";
            for (int i = 10; i < 100; i++)
            {
                if (i % 5 == 0)
                {
                    solution += $"{i} ";
                }
            }
            Console.WriteLine(solution);

        }
    }
}
