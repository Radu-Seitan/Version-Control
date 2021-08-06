using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Library myLibrary = new();
            Author AndrzejSapkowski = new("1", "Andrzej Sapkowski", new DateTime(1948, 6, 21));
            Author JRRTolkien = new("2", "J.R.R.Tolkien", new DateTime(1892, 1, 3));
            Author GeorgeRRMartin = new("3", "George R.R. Martin", new DateTime(1948, 9, 20));

            myLibrary.AddBook(new Book("1", "A Game of Thrones", new DateTime(1996, 7, 1), GeorgeRRMartin, new List<string>() { "medieval", "fantasy", "science-fiction" }));
            myLibrary.AddBook(new Book("2", "A Clash of Kings", new DateTime(1998, 11, 16), GeorgeRRMartin, new List<string>() { "medieval", "fantasy", "science-fiction" }));
            myLibrary.AddBook(new Book("3", "The Fellowship of the Ring", new DateTime(1954, 11, 16), JRRTolkien, new List<string>() { "medieval", "fantasy", "adventure" }));
            myLibrary.AddBook(new Book("4", "The Last Wish", new DateTime(1993, 11, 16), AndrzejSapkowski, new List<string>() { "medieval", "fantasy" }));
            myLibrary.AddBook(new Book("5", "A Dance of Dragons", new DateTime(2003, 11, 16), GeorgeRRMartin, new List<string>() { "medieval", "fantasy"}));
            Book aBook = new Book("6", "A World of Ice And Fire", new DateTime(2018, 11, 16), GeorgeRRMartin, new List<string>() { "medieval", "fantasy" });
            myLibrary.AddBook(aBook);

            Console.WriteLine("All books");
            foreach(Book b in myLibrary.GetAllBooks())
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("After deleting a book:");
            myLibrary.RemoveBook(aBook);
            foreach (Book b in myLibrary.GetAllBooks())
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("Books after 1980:");
            foreach (Book b in myLibrary.GetBooksByYear(new DateTime(1980,1,1)))
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("Books with science-fiction category:");
            foreach (Book b in myLibrary.GetBooksByCategory("science-fiction"))
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("Authors with 3 books:");
            foreach(Author a in myLibrary.GetAuthorsByNumberOfBooks(3))
            {
                Console.WriteLine(a + "\n");
            }
            Console.WriteLine("Authors born before 1900 with 1 fantasy book:");
            foreach (Author a in myLibrary.GetAuthorsByAgeNumberOfBooksAndCategory(new DateTime(1900,01,01),1,"fantasy"))
            {
                Console.WriteLine(a + "\n");
            }

            Console.WriteLine("Group by decade:");
            foreach (var group in myLibrary.GroupByDecade())
            {
                Console.WriteLine(group.Key);

                foreach (var item in group)
                {
                    Console.WriteLine($"{item}");
                }
            }
        }
    }
}
