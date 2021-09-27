using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // значение первой стороны прямоугольника
            double side1, side2;
            Console.WriteLine("Введите значение длинны прямоугольника: ");
            string inputSide1 = Console.ReadLine();
            
            Console.WriteLine("Введите значение ширины прямоугольника: ");
            string inputSide2 = Console.ReadLine();

            double.TryParse(inputSide1, out side1);
            double.TryParse(inputSide2, out side2);
            if (double.TryParse(inputSide1, out side1) & double.TryParse(inputSide2, out side2))
            {
                Console.WriteLine("Преобразование успешно");
                var rectangle = new Rectangle(side1, side2);
                Console.WriteLine("Площадь прямоугольника: {0} Периметр прямоугольника: {1}", rectangle.Area, rectangle.Perimetr);
            }
            else
            {
                return;
            }
        }
    }
}