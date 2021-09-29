using System;

namespace ConsoleApp3
{
    /// <summary>
    /// Класс фигуры
    /// </summary>
    public class Figure
    {
        /// <summary>
        /// Поле для периметра
        /// </summary>
        private double perimeter;
        
        /// <summary>
        /// Поле для точек
        /// </summary> 
        private Pointer A, B, C, D, E;
        
        /// <summary>
        /// Поле для наименования фигуры
        /// </summary>
        private string nameFigure;
        
        /// <summary>
        /// Поле для подсчёта колличества сторон
        /// </summary>
        private int count;

        /// <summary>
        /// Конструктор треугольника
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <param name="point3"></param>
        public Figure(Pointer _A, Pointer _B, Pointer _C)
        {
            this.A = _A;
            this.B = _B;
            this.C = _C;
            nameFigure = "Треугольник";
            count = 3;
        }
        
        /// <summary>
        /// Конструктор прямоугольника, квадрата и т.д.
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <param name="point3"></param>
        /// <param name="point4"></param>
        public Figure(Pointer _A, Pointer _B, Pointer _C, Pointer _D)
        {
            this.A = _A;
            this.B = _B;
            this.C = _C;
            this.D = _D;
            nameFigure = "Прямоугольник";
            count = 4;
        }
        
        /// <summary>
        /// Конструктор пятиугольника
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <param name="point3"></param>
        /// <param name="point4"></param>
        /// <param name="point5"></param>
        public Figure(Pointer _A, Pointer _B, Pointer _C, Pointer _D, Pointer _E)
        {
            this.A = _A;
            this.B = _B;
            this.C = _C;
            this.D = _D;
            this.E = _E;
            nameFigure = "Пятиугольник";
            count = 5;
        }

        public void InitializationFigure()
        {
            Console.WriteLine("Введите название фигуры: ");
            
        }
        
        /// <summary>
        /// Метод для расчёта стороны многоугольника
        /// </summary>
        /// <param name="X">Точка Х</param>
        /// <param name="Y">Точка У</param>
        /// <returns></returns>
        public double LengthSide(Pointer A, Pointer B)
        {
            return Math.Sqrt(Math.Pow((B.PointerA - A.PointerB), 2) + Math.Pow((B.PointerA - A.PointerB), 2));
        }
        
        /// <summary>
        /// Метод для расчёта многоуголька
        /// </summary>
        public void PerimetrCalculet()
        {
            if (count == 3)
            {
                perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(A, C);

                Console.WriteLine( "Эта фигура {0}, его периметр = {1}",nameFigure, perimeter) ;
            }

            if (count == 4)
            {
                perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(A,D);

                Console.WriteLine( "Эта фигура {0}, его периметр = {1}",nameFigure, perimeter) ;
            }

            if (count == 5)
            {
                perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D)+ LengthSide(D,E) + LengthSide(E,A);

                Console.WriteLine( "Эта фигура {0}, его периметр = {1}",nameFigure, perimeter) ;
            }
        }

    }
}