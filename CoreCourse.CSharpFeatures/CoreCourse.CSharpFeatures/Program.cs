using CoreCourse.CSharpFeatures.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CoreCourse.CSharpFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

            List<string> bookInfos = new List<string>();

            foreach (Book book in Book.GetAll())
            {
                string title = book?.Title ?? "[untitled book]";
                int? pages = book?.Pages ?? 0;
                string sequelTitle = book?.Sequel?.Title ?? "[no sequels]";
                bookInfos.Add($"Title: {title}, Pages: {pages:N0}, Sequel: {sequelTitle}");
            }

            BookRepository bookRepository = new BookRepository { Books = Book.GetAll() };

            //calculate total number of pages
            int totalPages = bookRepository.TotalPages();
            bookInfos.Add($"\r\nTotal pages in repository: {totalPages:N0}");

            //calculate total pages of all known books
            int totalPagesKnownBooks = Book.GetAll().TotalPages();
            bookInfos.Add($"Total pages of known books: {totalPagesKnownBooks:N0}");

            //count the number of known books with more than 350 pages
            int numberOfknownBooksWithOver350p = Book.GetAll().GetByMinimumPages(350).Count();
            bookInfos.Add($"# books with > 350 pages: {numberOfknownBooksWithOver350p:N0}");

            //get books starting with letter 
            int numberOfKnownBooksWithLetterT = Book.GetAll().GetByFirstLetter('T').Count();
            bookInfos.Add($"# books starting with 'T': {numberOfKnownBooksWithLetterT:N0}");

            PrintStrings(bookInfos);

            //prevent quitting in debug mode
            Console.WriteLine("\n\rPress any key to exit");
            Console.Read();
        }

        static void PrintStrings(IEnumerable<string> strings)
        {
            foreach (var s in strings)
            {
                Console.WriteLine(s);
            }
        }
    }
}
