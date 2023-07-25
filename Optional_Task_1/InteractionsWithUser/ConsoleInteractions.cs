using System;
namespace Optional_Task_1
{
    public class ConsoleInteractions: ITextInteractions
    {

        public string RequestInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}
