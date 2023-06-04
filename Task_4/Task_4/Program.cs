/*Создать массив элементов произвольного типа. 
 * С помощью циклов перебрать все элементы этого массива и вывести их в консоль.
*/

using System;

namespace Task_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            object[] arr1 = { 15, "Hello", 15.64, "Disco" };

            foreach (object arr in arr1)
                {
                Console.WriteLine(arr);
            }
            
        }
    }
}
