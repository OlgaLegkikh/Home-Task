/*2) С помощью цикла с постусловием(do...while) вывести на экран 
 * в столбик последовательность чисел : -20, -40, ...,-100.
 */

using System;

namespace Task_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int i = -20;
            do
            {
                Console.WriteLine(i);
                i -= 20;

            } while (i >= -100);
        }
    }
}
