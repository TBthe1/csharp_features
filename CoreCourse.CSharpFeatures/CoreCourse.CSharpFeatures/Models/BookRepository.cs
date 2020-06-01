using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CoreCourse.CSharpFeatures.Models
{
    public class BookRepository
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
