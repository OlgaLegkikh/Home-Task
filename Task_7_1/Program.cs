//7
//Создать 2 или больше собственных классов исключения, не забыть назвать их с Exception на конце. ;)
//Создать класс A принимающий в метод(ы) аргумент типа string и выбрасывающий эти исключения в какой-нибудь ситуации.
//Например, если строка пустая, если содержит спец-символ, если не заканчивается на точку, если Луна не растёт и т.д.
//В классе Program вызывать метод(ы) класса А, обработать все возможные исключения и выводить пользователю сообщение,
//соответствующее пойманному исключению.


using System;

namespace Task_7_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            User user = new User();
            Console.WriteLine("Добро пожаловать в редактор для создания борды для игры в Змеи и Лестницы, {0}", user.UserName);

                Board SNL_board = new Board();
                MoverCollection<Mover> movers = new MoverCollection<Mover>();
                while (movers.Count <= 10)
                {
                    Console.WriteLine("Муверов на борде: {0}. Максимальное количество муверов - 10", movers.Count);
                    Console.WriteLine("Если муверов достаточно нажмите 0");
                    Console.WriteLine("Если  хотитe добавить еще мувер нажмите 1");
                    string userInput = Console.ReadLine();
                    if (userInput == "0")
                    {
                        break;
                    }
                    if (userInput == "1")
                    {
                    Mover mover = new Mover(SNL_board);
                    movers.Add(mover);
                    }
                    else
                    {   
                    Console.WriteLine("Пожалуйста введите корректную команду!");
                    }
                }
            Console.WriteLine("Параметры борды получены, {0}", user.UserName);

            
            for (int i =1; i <= SNL_board.BoardLength; i++)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                foreach (Mover mover in movers)
                    {

                        if (mover.StartCell == i || mover.FinishCell == i)
                        {
                            if (mover.MoverType == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                            }
                            if (mover.MoverType == 1)
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                            }

                        }
                        
                    }
                if (i % SNL_board.BoardLine == 0)
                {
                    Console.WriteLine("░");
                }
                else
                {
                    Console.Write("░");
                }




            }



        }
    }
}
