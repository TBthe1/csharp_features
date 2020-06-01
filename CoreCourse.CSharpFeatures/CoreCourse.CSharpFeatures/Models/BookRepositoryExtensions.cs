using System;
using System.Collections.Generic;
using System.Text;

namespace CoreCourse.CSharpFeatures.Models
{
    public static class IEnumerableBookExtensions
    {
        public static int TotalPages(this IEnumerable<Book> bookCollection)
        {
            int totalPages = 0;
            foreach (Book book in bookCollection)
                totalPages += book?.Pages ?? 0;

            return totalPages;
        }

        public static IEnumerable<Book> GetByMinimumPages(
            this IEnumerable<Book> bookCollection, int minimumPages)
        {
            var booksFound = new List<Book>();

            foreach (Book book in bookCollection)
                if ((book?.Pages ?? 0) >= minimumPages)
                    yield return book;
        }

        public static IEnumerable<Book> GetByFirstLetter(
            this IEnumerable<Book> bookCollection, char firstLetter)
        {
            foreach (Book book in bookCollection)
                if (book?.Title?[0] == firstLetter)
                    yield return book;
        }
    }
}
