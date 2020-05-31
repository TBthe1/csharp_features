using CoreCourse.CSharpFeatures.Models;
using System;
using System.Collections.Generic;

namespace CoreCourse.CSharpFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> bookInfos = new List<string>();

            foreach (Book book in Book.GetAll())
            {
                string title = book?.Title;
                int? pages = book?.Pages;
                string sequelTitle = book?.Sequel?.Title;
                bookInfos.Add(string.Format("Title: {0}, Pages: {1}, Sequel: {2}", title, pages, sequelTitle));
            }

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
