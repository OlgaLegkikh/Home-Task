using System;

namespace Magic_Task_5
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            string instructions = @"
            You can cast the spell or attack the enemies.
            To cast the spell to make your sword stronger enter 1
            To cast the spell to heal enter 2
            To cast the spell to make mana from your health enter 3
            To attack the enemy enter 4
            To see this instructions again enter  5
            To stop the game enter 6";



            var whiteFire = new WhiteFire();
            var lifeWater = new LifeWater();
            var deadWater = new DeadWater();
            var swordAttack = new Attack();
            bool gameOn = true;

            Console.WriteLine("Hello! Welcome to the Magic World! Please introduce yourself!");
            string userName = Console.ReadLine();
            Console.WriteLine($"Your are an young magician, {userName}");

            Console.WriteLine(instructions);
            while (gameOn)
            {
               Console.WriteLine($"Your choice {userName}");
               int userEnter =  Convert.ToInt32(Console.ReadLine());
               switch (userEnter)
                {
                    case 6:
                        gameOn = false;
                        Console.WriteLine($"See you soon, {userName}!");
                        break;
                    case 5:
                        Console.WriteLine(instructions);
                        break;
                    case 4:
                        swordAttack.UserAttack();
                        break;
                    case 3:
                        deadWater.CastDeadWater();
                        break;
                    case 2:
                        lifeWater.CastLifeWater();
                        break;
                    case 1:
                        whiteFire.CastWhiteFire();
                        break;
                    default: Console.WriteLine("I don't know this magic :(");
                        break;
                }

            }

        }
    }
}
