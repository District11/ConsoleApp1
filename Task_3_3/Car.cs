using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_3
{
    /// <summary>
    /// Класс машины наследующийся от класса транспорт
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Конструктор машины
        /// </summary>
        /// <param name="xPoint">Координата х</param>
        /// <param name="yPoint">Координата у</param>
        /// <param name="price">Цена машины</param>
        /// <param name="speed">Скорость машины</param>
        /// <param name="year">Год выпуска машины</param>
        public Car(float xPoint, float yPoint, int price, int speed, int year) : base(xPoint, yPoint, price, speed,
            year)
        {
        }

        /// <summary>
        /// Конструктор машины
        /// </summary>
        /// <param name="price">Цена машины</param>
        /// <param name="speed">Скорость машины</param>
        /// <param name="year">Год выпуска машины</param>
        public Car(int price, int speed, int year) : base(price, speed, year)
        {
        }
    }
}
