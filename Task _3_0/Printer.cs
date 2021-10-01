using System;

namespace Task__3_0
{
    public class ConsolePrinter: Printer
    {
        public ConsolePrinter(ConsoleColor color) : base(color)
        {
            
        }
    }
    
    public class Printer
    {
        /// <summary>
        /// Поле цвета
        /// </summary>
        public ConsoleColor color;

        /// <summary>
        /// Конструктор для цвета
        /// </summary>
        /// <param name="color">Цвет</param>
        public Printer(ConsoleColor color)
        {
            this.color = color;
        }
        
        
        public void Print(string value)
        {
            Console.ForegroundColor = color; //Задает цвет текста консоли.
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}