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
        private double _perimeter;
        
        /// <summary>
        /// Поле для точек
        /// </summary> 
        private Pointer _a, _b, _c, _d, _e;
        
        /// <summary>
        /// Поле для наименования фигуры
        /// </summary>
        private string _nameFigure;
        
        /// <summary>
        /// Поле для подсчёта колличества сторон
        /// </summary>
        private int _count;

        /// <summary>
        /// Конструктор треугольника
        /// </summary>
        /// <param name="a">1 сторона</param>
        /// <param name="b">2 сторона</param>
        /// <param name="с">3 сторона</param>
        public Figure(Pointer a, Pointer b, Pointer c)
        {
            //Инциализация сторон треугольника
            this._a = a;
            this._b = b;
            this._c = c;
            _nameFigure = "Треугольник";
            _count = 3;
        }

        /// <summary>
        /// Конструктор прямоугольника, квадрата и т.д.
        /// </summary>
        /// <param name="a">1 сторона</param>
        /// <param name="b">2 сторона</param>
        /// <param name="c">3 сторона</param>
        /// <param name="d">4 сторона</param>
        public Figure(Pointer a, Pointer b, Pointer c, Pointer d)
        {
            //Инциализация сторон прямоугольника
            this._a = a;
            this._b = b;
            this._c = c;
            this._d = d;
            _nameFigure = "Прямоугольник";
            _count = 4;
        }

        /// <summary>
        /// Конструктор пятиугольника
        /// </summary>
        /// <param name="a">1 сторона</param>
        /// <param name="b">2 сторона</param>
        /// <param name="c">3 сторона</param>
        /// <param name="d">4 сторона</param>
        /// <param name="e">5 сторона</param>
        public Figure(Pointer a, Pointer b, Pointer c, Pointer d, Pointer e)
        {
            //Инциализация сторон пятиугольника
            this._a = a;
            this._b = b;
            this._c = c;
            this._d = d;
            this._e = e;
            _nameFigure = "Пятиугольник";
            _count = 5;
        }
        
        /// <summary>
        /// Метод для расчёта стороны многоугольника
        /// </summary>
        /// <param name="A">Точка A</param>
        /// <param name="B">Точка B</param>
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
            if (_count == 3)
            {
                _perimeter = LengthSide(_a, _b) + LengthSide(_b, _c) + LengthSide(_a, _c);

                Console.WriteLine( "Эта фигура {0}, его периметр = {1}", _nameFigure, _perimeter) ;
            }

            if (_count == 4)
            {
                _perimeter = LengthSide(_a, _b) + LengthSide(_b, _c) + LengthSide(_c, _d) + LengthSide(_a,_d);

                Console.WriteLine( "Эта фигура {0}, его периметр = {1}",_nameFigure, _perimeter) ;
            }
            
            if (_count == 5)
            {
                _perimeter = LengthSide(_a, _b) + LengthSide(_b, _c) + LengthSide(_c, _d)+ LengthSide(_d,_e) + LengthSide(_e,_a);

                Console.WriteLine( "Эта фигура {0}, его периметр = {1}",_nameFigure, _perimeter) ;
            }
        }
    }
}