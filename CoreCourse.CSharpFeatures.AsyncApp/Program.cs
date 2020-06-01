using System;

namespace CoreCourse.CSharpFeatures.AsyncApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //collection initialization with anonymous types 
            var siteDefinitions = new[]
            {
                new { Url = "http://www.google.com", Rating=90 },
                new { Url = "https://www.stackoverflow.com", Rating=80 },
                new { Url = "https://www.codeproject.com", Rating=75 },
                new { Url = "http://www.deredactie.be", Rating=70 },
                new { Url = "http://www.svt.se", Rating=70 },
                new { Url = "https://www.github.com", Rating=75 },
            };

            //prevent quitting in debug mode 
            Console.WriteLine($"\r\nPress any key to exit");
            Console.Read();
        }
    }
}
