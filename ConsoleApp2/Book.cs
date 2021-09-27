using System;

namespace ConsoleApp2
{
    public class Book
    {
        public class Tittle
        {
            public string tittle;

            public static void Show()
            {
                Console.WriteLine("Content: {0}");
            }
        }
        
        public class Author
        {
            public string author;
            public static void Show()
            {
                Console.WriteLine("Content: {0}");
            }
        }
        
        public class Content
        {
            public string content;

            public static void Show()
            {
                Console.WriteLine("Content: {0}");
            }
        }
    }
}