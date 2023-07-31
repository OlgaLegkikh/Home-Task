using System;
namespace Optional_Task_1
{
    public class ConsoleInteractions: ITextInteractions
    {

        public string RequestInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public uint RequestInputInInt(string prompt)
        {
            try
            {
                Console.Write(prompt);
                return Convert.ToUInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите натуральное число!");
                return RequestInputInInt(prompt);
            }
        }

        public bool RequestInputInBool(string prompt)
        {
            Console.Write(prompt);
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "да")
            {
                return true;
            }
            if (userInput.ToLower() == "нет")
            {
                return false;
            }
            else
            { 
                Console.WriteLine("Введите \"да\" или \"нет\"");
                return RequestInputInBool(prompt);
            }
        }
    }
}
