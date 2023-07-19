/* Доска для игры в Змеи и Лестницы. 
 * Состоит из клеток, которые складываются в линии, Змей, Лестниц и Подарков. 
 * 
 * Минимальное значение клеток в линии - 5. Максимальное - 10*/
using System;
namespace Task_7_1
{
    public class Board
    {
        public int BoardLine;
        public int BoardLength;
        public Board()
        {
            BoardLine = CreateBoardLine();
            BoardLength = CreateBoardLenght();
        }

        private int CreateBoardLine()
        {
            Console.WriteLine("Введите длину линии на доске. Диапазон от 5 до 10.");

            string userInput = Console.ReadLine();
            try
            {
                int boardLineLength = Int32.Parse(userInput);
                BoardLineValidate(boardLineLength);
                return boardLineLength;
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите число!");
                return CreateBoardLine();
            }
            catch (InvalidBoardParametrException)
            {
                return CreateBoardLine();
            }

        }

        private void BoardLineValidate(int boardLine)
        {
            if (boardLine < 5 || boardLine > 10)
            {
                throw new InvalidBoardParametrException("Размер линии вне диапазона!");
            }
        }

        private int CreateBoardLenght()
        {
            Console.WriteLine($"Введите количество клеток на доске. Диапазон от {BoardLine * 2} до 100.");

            string userInput = Console.ReadLine();
            try
            {
                int boardLength = Int32.Parse(userInput);
                BoardLengthValidate(boardLength);
                return boardLength;
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите число!");
                return CreateBoardLenght();
            }
            catch (InvalidBoardParametrException)
            {
                return CreateBoardLenght();
            }
        }

        private void BoardLengthValidate(int boardLength)
        {
            if ((boardLength < (this.BoardLine * 2)) || boardLength > 100)
            {
                throw new InvalidBoardParametrException("Размер поля вне диапазона!");
            }
        }

    }
}
