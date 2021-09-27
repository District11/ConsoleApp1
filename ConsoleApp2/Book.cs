using System;

namespace ConsoleApp2
{
    /// <summary>
    /// Класс книги
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Название книги 
        /// </summary>
        public Title _title;
        
        /// <summary>
        /// Автор книги 
        /// </summary>
        public Author _author;
        
        /// <summary>
        /// Содержание книги
        /// </summary>
        public Content _content;

        /// <summary>
        /// Класс книги
        /// </summary>
        /// <param name="title">Название книги</param>
        /// <param name="author">Автор книги</param>
        /// <param name="content">Содержание книги</param>
        public Book(string title, string author, string content)
        {
            this._title = new Title(title);
            this._author = new Author(author);
            this._content = new Content(content);
        }

        /// <summary>
        /// Метод выведения информации
        /// </summary>
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Название книги: {_title}");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Автор книги: {_author}");
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Содержание книги: {_content}");
        }


        /// <summary>
        /// Метод для добавления книги
        /// </summary>
        public void AddBook()
        {
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Введите название книги: ");
            string title = Console.ReadLine();
            this._title = new Title(title);
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите название автора: ");
            string author = Console.ReadLine();
            this._author = new Author(author);
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Введите контент: ");
            string content = Console.ReadLine();
            this._content = new Content(content);
            
        }
    }

    /// <summary>
    /// Класс названия книги
    /// </summary>
    public class Title
    {
        private string _title;
        
        /// <summary>
        /// Конструктор названия
        /// </summary>
        /// <param name="title"></param>
        public Title(string title)
        {
            this._title = title;
        }
    }
    /// <summary>
    /// Класс Автор
    /// </summary>
    public class Author
    {
        private string _author;

        /// <summary>
        /// Конструктор автора
        /// </summary>
        /// <param name="author"></param>
        public Author(string author)
        {
            this._author = author;
        }

    }

    /// <summary>
    /// Класс названия содержания
    /// </summary>
    public class Content
    {
        private string _content;

        /// <summary>
        /// Конструктор содержания книги
        /// </summary>
        /// <param name="content"></param>
        public Content(string content)
        {
            this._content = content;
        }
    }
}