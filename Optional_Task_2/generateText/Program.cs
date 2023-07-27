//2
//1 - Создать генератор случайного "текста", записывающего вывод в файл.
//Использование:
//generateText.exe<filepath> < textLength >
//Генератор должен записывать в файл случайный "текст" любой длины,
//обязательно протестировать хотяб разок на значении 40000000000 (40ГБ) или любом другом, превышающем размер оперативной памяти. ;)
//Для такой задачи необходим будет StreamWriter.
//"Текст" в кавычках, потому что требование к нему только одно — чтобы символы периодически разделялись пробелами. ;)

//2 - После этого создать читатель для таких файлов, позволяющий прочитать слово из текста по его порядковому номеру в тексте.
//getWord.exe <filepath> <wordnumber>
//Генератор должен считать слова в текстовом файле, пока не дойдёт до того номера слова, которое указано в команде, и тогда вывести в консоль это слово.
using System;
using System.IO;
using System.Threading.Tasks;

namespace Optional_Task_2
{
    class MainClass
    {
        public static async Task Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Пожалуйста введите путь к файлу и размер текста");
            }
            string path = args[0];
            string textLength = args[1];
            
            RandomTextGenerator rndText = new RandomTextGenerator();

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                try
                {
                    await writer.WriteLineAsync(rndText.RandomString(int.Parse(textLength)));
                    Console.WriteLine("Файл создан");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

        }
    }
}
