/*Task Description 
 * Принять символ с клавиатуры. 
 * Определить, необходимо ли нам переместить фигуру вверх, вниз, вправо, влево 
 * в зависимости от введенного символа (например, W, S, A, D). Вывести результат решения на экран. 
 * В случае отсутствия необходимости перемещения вывести соответствующее сообщение.
*/
using System;

namespace Task_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the symbol");
            string symbol = Console.ReadLine();

            switch (symbol.ToUpper())
            {
                case "W":
                    Console.WriteLine("Cursor goes up");
                    break;
                case "S":
                    Console.WriteLine("Cursor goes down");
                    break;
                case "D":
                    Console.WriteLine("Cursor goes right");
                    break;
                case "A":
                    Console.WriteLine("Cursor goes left");
                    break;
                default:
                    Console.WriteLine("I don't this symbol. Cursor doesn't move");
                    break;
            }
        }
    }
}
