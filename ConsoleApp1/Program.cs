using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // значение первой стороны прямоугольника
            Console.WriteLine("Введите значение длинны прямоугольника: ");
            double side1 =  Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите значение ширины прямоугольника: ");
            double side2 =  Convert.ToDouble(Console.ReadLine());
            
            var rectangle = new Rectangle(side1, side2);
            Console.WriteLine("Площадь прямоугольника: {0} Периметр прямоугольника: {1}", rectangle.Area, rectangle.Perimetr);
        }
    }
}