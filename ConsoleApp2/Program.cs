using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Q", "Bob", "adsmkdsk" );
            book.AddBook();
            book.Show();
        }
    }
}