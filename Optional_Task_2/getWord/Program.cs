using System;
using System.IO;

namespace getWord
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            if(args.Length != 2)
            {
                Console.WriteLine("Пожалуйста введите путь к файлу и номер слова которое хотите найти");
            }

            string path = args[0];
            string wordNumber = args[1];

            try
            {

                using (StreamReader sr = new StreamReader(path))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        //Console.WriteLine(line);
                        var array = line.Split(new[] { ' ' });

                        Console.WriteLine(array[int.Parse(wordNumber) - 1]);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Не удалось найти файл");
            }
            catch (FormatException)
            {
                
                Console.WriteLine("Пожалуйста укажите число");
            }
            catch(IndexOutOfRangeException)
            {
                
                Console.WriteLine("В тексте меньше слов");
            }
            catch (Exception e)
            {
                
                Console.WriteLine("Слово не может быть найдено");
                Console.WriteLine(e.Message);
            }


        }
    }
}
