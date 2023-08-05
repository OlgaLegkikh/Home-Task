using System;
using System.Collections.Generic;

namespace Optional_Task_1
{
public class Library
    {
        public List<Publication> Books { get; set; }
    }
public class Publication
    {
        public string? Name { get; set; }
        public List<Author> Authors { get; set; }
        public string Language { get; set; }
        public bool IsRead { get; set; }
    }
public class Author
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }

    }
}
