using System;
using System.Collections.Generic;
using System.Text;

namespace CoreCourse.CSharpFeatures.Models
{
    public static class BookRepositoryExtensions
    {
        public static int TotalPages(this BookRepository bookrepository)
        {
            int totalPages = 0;
            foreach (Book book in bookrepository.Books)
                totalPages += book?.Pages ?? 0;

            return totalPages;
        }
    }
}
