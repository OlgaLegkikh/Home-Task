//дз опциональная 1
//Создать класс, содержащий в себе в качестве публичных свойств два-три других класса (возможно, вложенных друг в друга).
//Можно использовать какую-нибудь из созданных в предыдущих ДЗ структур. ;)

//Запросить у пользователя шаг-за-шагом все хранящиеся в этих классах данные, поясняя пользователю(тренируемся попутно в UX), что происходит.
//При этом постараться избегать копирования кода. Как минимум, вывести процедуру запроса данных у пользователя в отдельный класс
//ConsoleInteractions : ITextInteractions, содержащий метод
//string RequestInput(string prompt).
//По окончании ввода данных пользователем, сохранить получившийся объект в файле в формате json, xml или каком угодно ещё читабельном формате.
//Не забыть добавить в .gitignore выходной файл. ; )

//Следующий шаг — при старте программы читать тот же самый файл и показывать пользователю текущие значения, затем переходить к той же процедуре ввода новых данных,
//но не изменять их, если пользователь вводит пустую строку.

//Следующий шаг — при старте программы проверять, не пришло ли аргумента из командной строки.
//Если пришло — использовать его как имя файла. ;)

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Optional_Task_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ConsoleInteractions console = new ConsoleInteractions();
            var Books = new Library();
            bool isOn = true;
            while (isOn)
            {
                Books
                
            }

            var option = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize<Library>(Books, option);
            Console.WriteLine(jsonString);
            string fileName = "Library.json";
            File.WriteAllText(fileName, jsonString);



        }
    }
}
