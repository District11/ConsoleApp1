using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
