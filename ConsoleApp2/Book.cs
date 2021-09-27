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
            
            this._title.Show();
            this._author.Show();
            this._content.Show();
            
        }
        
        /// <summary>
        /// Метод для добавления книги
        /// </summary>
        public void AddBook()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Введите название книги: ");
            string title = Console.ReadLine();
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите название автора: ");
            string author = Console.ReadLine();
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Введите контент: ");
            string content = Console.ReadLine();
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Название: {title}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Автор: {author}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Контент: {content}");
        }
    }

    /// <summary>
    /// Класс названия книги
    /// </summary>
    public class Title
    {
        private string _title;

        /// <summary>
        /// Метод для выведения информации о названии книги
        /// </summary>
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Название книги: ");
        }
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
        /// Метод для выведения информации об авторе
        /// </summary>
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Автор книги: ");
        }
       
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
        /// Метод для выведения информации о содержании книги
        /// </summary>
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Содержание книги: ");
        }
        
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