using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public DateTime DateOfPublish { get; set; }
        public Author BookAuthor { get; set; }
        public List<string> Categories { get; init; } = new();

        public Book(string id, string title, DateTime dateOfPublish, Author bookAuthor, List<string> categories)
        {
            Id = id;
            Title = title;
            DateOfPublish = dateOfPublish;
            BookAuthor = bookAuthor;
            Categories = categories;
            bookAuthor.PublishedBooks.Add(this);  //When a new book is created, it is automatically added to the list of published books of its author.
        }

        public override string ToString()
        {
            return $"{Id} {Title} {DateOfPublish} {BookAuthor} \nCategories: {string.Join(" ",Categories)} \n";
        }
    }
}
