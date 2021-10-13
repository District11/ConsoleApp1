using System;

namespace Task__3_0
{
    /// <summary>
    /// Класс консольной печати, которая наследуется от родительского Printer
    /// </summary>
    public class ConsolePrinter : Printer
    {
        /// <summary>
        /// Конструктор для консольной печати
        /// </summary>
        /// <param name="color">Цвет</param>
        public ConsolePrinter(ConsoleColor color) : base(color) { }
    }

    /// <summary>
    /// Класс печати
    /// </summary>
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

        /// <summary>
        /// Выведение значнеия
        /// </summary>
        /// <param name="value">Значение, которое передаётся в консоль</param>
        public void Print(string value)
        {
            Console.ForegroundColor = color; //Задает цвет текста консоли.
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}