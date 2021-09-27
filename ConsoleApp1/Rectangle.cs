using System;

namespace ConsoleApp1
{
    public class Rectangle
    {
        // Значнеие первой сторорны прямоугольника
        double side1;
        // Значнеие второй сторорны прямоугольника
        double side2;
        
        
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        
        /// <summary>
        /// Метод для расчёта площади прямоугольника
        /// </summary>
        /// <returns></returns>
        public double AreaCalculator()
        {
           double result = side1 * side2;
           return result;
        }
        
        /// <summary>
        /// Метод для расчёта периметра
        /// </summary>
        /// <returns></returns>
       public double PerimetrCalculate()
       {
           double result = 2*(side1 + side2);
           return result;
       }

        public double Area
        {
            get
            {
                return this.AreaCalculator();
            }
        }

        public double Perimetr
        {
            get
            {
                return this.PerimetrCalculate();
            }
        }
    }
}