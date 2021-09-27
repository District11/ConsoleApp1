using System;

namespace ConsoleApp1
{
    /// <summary>
    /// Класс прямоугольника
    /// </summary>
    public class Rectangle
    {
        // Значнеие первой сторорны прямоугольника
       private readonly double _side1;
        // Значнеие второй сторорны прямоугольника
       private readonly double _side2;
        
        /// <summary>
        /// Конструктор прямоугольника
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        public Rectangle(double side1, double side2)
        {
            this._side1 = side1;
            this._side2 = side2;
        }
        
        /// <summary>
        /// Метод для расчёта площади прямоугольника
        /// </summary>
        /// <returns></returns>
        public double AreaCalculator()
        {
           double result = _side1 * _side2;
           return result;
        }
        
        /// <summary>
        /// Метод для расчёта периметра
        /// </summary>
        /// <returns></returns>
       public double PerimetrCalculate()
        {
            double result = 2 * (_side1 + _side2);
            return result;
        }

        /// <summary>
        /// Свойство площади
        /// </summary>
        public double Area
        {
            get
            {
                return this.AreaCalculator();
            }
        }

        /// <summary>
        /// Свойство периметр
        /// </summary>
        public double Perimetr
        {
            get
            {
                return this.PerimetrCalculate();
            }
        }
    }
}