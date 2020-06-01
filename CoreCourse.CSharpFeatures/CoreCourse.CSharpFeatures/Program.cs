﻿using CoreCourse.CSharpFeatures.Models;
using System;
using System.Collections.Generic;
using System.Globalization;

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
