using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Optional_Task_1
{
    public class JsonCreation
    {
        public JsonCreation()
        {
            ConsoleInteractions console = new ConsoleInteractions();
            var userBooks = new List<Publication>();
            Library library = new Library();
            bool isOn = true;
            while (isOn)
            {
                if (console.RequestInputInBool("Введите \"да\" если хотите добавить книгу: "))
                {
                    Publication book = new Publication();
                    book.Name = console.RequestInput("Введите название книги: ");
                    var bookAuthors = new List<Author>();
                    uint i = console.RequestInputInInt("Введите количество авторов книги: ");
                    int j = 1;
                    while (j <= i)
                    {
                        string firstName = console.RequestInput($"Введите имя автора №{j}: ");
                        string secondName = console.RequestInput($"Введите фамилию автора №{j}: ");
                        bookAuthors.Add(new Author { FirstName = firstName, SecondName = secondName });
                        j++;
                    }
                    book.Authors = bookAuthors;
                    book.Language = console.RequestInput("Укажите на каком языке написана книга: ");
                    book.IsRead = console.RequestInputInBool("Введите \"да\", если книга прочитана, или \"нет\" если книга не прочитана: ");
                    userBooks.Add(book);
                }

                else
                {
                    isOn = false;
                    library.Books = userBooks;
                    Console.WriteLine("Список книг подготовлен");
                }

            }

            var option = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize<Library>(library, option);
            //Console.WriteLine(jsonString);
            string fileName = "Library.json";
            File.WriteAllText(fileName, jsonString);
        }
    }
}
