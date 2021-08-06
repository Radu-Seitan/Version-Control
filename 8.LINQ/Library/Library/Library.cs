using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Library
    {
        private List<Book> _booksInLibrary = new();

        public void AddBook(Book bookToBeAdded) => _booksInLibrary.Add(bookToBeAdded);

        public void RemoveBook(Book bookToBeDeleted) => _booksInLibrary.Remove(bookToBeDeleted);

        public List<Book> GetAllBooks() => _booksInLibrary;

        public List<Book> GetBooksByYear(DateTime date) =>
            _booksInLibrary.Where(b => b.DateOfPublish >= date)
                .ToList();

        public List<Book> GetBooksByCategory(string category) =>
            _booksInLibrary.Where(b =>
                b.Categories.Contains(category))
            .ToList();

        //By grouping the books by their author and then making a list with their keys, a list with all the authors has been created.
        //Without the GroupBy operation, we would have had duplicates in the list of authors. 
        public List<Author> GetAuthorsByNumberOfBooks(int numberOfBooks) =>
            _booksInLibrary.GroupBy(b => b.BookAuthor)
                .Select(x => x.Key)
                .Where(author => author.PublishedBooks.Count >= numberOfBooks)
                .ToList();

        public List<Author> GetAuthorsByAgeNumberOfBooksAndCategory(DateTime date, int numberOfBooks, string category) =>
            _booksInLibrary.GroupBy(b => b.BookAuthor)
                     .Select(x => x.Key)
                     .Where(x =>
                         x.DateOfBirth <= date && x.PublishedBooks.Count(b =>
                            b.Categories.Contains(category)
                         ) >= numberOfBooks
                    ).ToList();
        

        public IEnumerable<IGrouping<double, Book>> GroupByDecade() =>
            _booksInLibrary.GroupBy(b => Math.Floor((double)(b.DateOfPublish.Year / 10)) * 10);
    }
}
