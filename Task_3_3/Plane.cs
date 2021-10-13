using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_3
{
    /// <summary>
    /// Класс самолета наследующийся от класса транспорт
    /// </summary>
    public class Plane : Vehicle
    {
        /// <summary>
        /// Конструктор самолёта
        /// </summary>
        /// <param name="xPoint">Координата х</param>
        /// <param name="yPoint">Координата у</param>
        /// <param name="price">Цена самолета</param>
        /// <param name="speed">Скорость самолета</param>
        /// <param name="year">Год выпуска самолета</param>
        public Plane(float xPoint, float yPoint, int price, int speed, int year) : base(xPoint, yPoint, price,
            speed, year)
        {
        }

        /// <summary>
        /// Конструктор самолёта
        /// </summary>
        /// <param name="price">Цена самолета</param>
        /// <param name="speed">Скорость самолета</param>
        /// <param name="year">Год выпуска самолета</param>
        public Plane(int price, int speed, int year) : base(price, speed, year)
        {
        }

        /// <summary>
        /// Поле пассажиров
        /// </summary>
        private int _passengers;

        /// <summary>
        /// Свойство пассажиров
        /// </summary>
        public int Passengers
        {
            get => _passengers;
            set
            {
                if (_passengers < 0)
                {
                    Console.WriteLine("Количетво пасажиров не может быть отрицательным");
                }
                else
                {
                    _passengers = value;
                }
            }
        }
    }
}
