using System;
namespace Task_7_1
{
    public class Mover
    {
        public int StartCell;
        public int FinishCell;
        public int MoverType; //0 - змея, 1 - лестница
        public Board InnerBoard;

        public Mover(Board innerBoard)
        {
            InnerBoard = innerBoard;
            MoverType = CreateMoverType();
            int[] cells = CreateMover();
            StartCell = cells[0];
            FinishCell = cells[1];
            
        }


        public void MoverTypeValidate(int moverType)
        {
            if (moverType < 0 || moverType > 1)
            {
                throw new InvalidMoverException("Такой тип мувера не поддерживается");
            }
        }

        public void MoverCellsValidate(int startCell, int finishCell)
        {
            if (startCell == finishCell)
            {
                throw new InvalidMoverException("Мувер не может начинаться и заканчиваться на одной и той же клетке");
            }
            if (startCell == 1 || finishCell == 1)
            {
                throw new InvalidMoverException("Мувер не может располагаться на первой клетке");
            }
            if (startCell == InnerBoard.BoardLength || finishCell == InnerBoard.BoardLength)
            {
                throw new InvalidMoverException("Мувер не может располагаться на последней клетке");
            }
            if (startCell < 1 || startCell > InnerBoard.BoardLength)
            {
                throw new InvalidMoverException("Мувер не может располагаться  за пределами поля");
            }
            if(finishCell < 1 || finishCell > InnerBoard.BoardLength)
            {
                throw new InvalidMoverException("Мувер не может располагаться  за пределами поля");
            }
            if(this.MoverType == 0 && (startCell < finishCell))
            {
                throw new InvalidMoverException("Змея должна вести вниз");
            }
            if (this.MoverType == 1 && (startCell > finishCell))
            {
                throw new InvalidMoverException("Лестница должна вести вверх");
            }

        }

        public int CreateMoverType()
        {
            Console.WriteLine("Введите тип мувера 0 - змея, 1 - лестница");
            string userInput = Console.ReadLine();
            try
            {

                int moverType = Int32.Parse(userInput);
                MoverTypeValidate(moverType);
                return moverType;
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите число!");
                return CreateMoverType();
            }
            catch (InvalidMoverException)
            {
                return CreateMoverType();
            }
        }
        
        public int[] CreateMover()
        {
            int[] cells = new int[2];
            try
            {
                Console.WriteLine("Введите номер клетки с которой начинается мувер");
                cells[0] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите номер клетки на которой заканчивается мувер");
                cells[1] = Int32.Parse(Console.ReadLine());
                MoverCellsValidate(cells[0], cells[1]);
                return cells;
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите число!");
                return CreateMover();
            }
            catch (InvalidMoverException)
            {
                return CreateMover();
            }
            
        }
    }
}
