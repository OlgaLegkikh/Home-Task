/*
 * - Создать двумерный массив 3х3. Значения элементов массива инициализировать при объявлении массива. 
 * - Вывести на экран значения максимального элемента каждого ряда
*/

using System;
using System.Linq;

namespace Task_3_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[][] arrayOfArrays = {
                    new int[3]{17,22,30},
                    new int[3]{6,70,8}
                    };
           
         Console.WriteLine($"Максимальное значение первого ряда {arrayOfArrays[0].Max()}");
         Console.WriteLine($"Максимальное значение второго ряда {arrayOfArrays[1].Max()}");
        }
    }
}
