using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_3
{

    /// <summary>
    /// Класс корабля зависимый от класса транспорт
    /// </summary>
    public class Ship : Vehicle
    {
        /// <summary>
        /// Конструктор корабля
        /// </summary>
        /// <param name="xPoint">Координата х</param>
        /// <param name="yPoint">Координата у</param>
        /// <param name="price">Цена Коробля</param>
        /// <param name="speed">Скорость Коробля</param>
        /// <param name="year">Год выпуска Коробля</param>
        public Ship(float xPoint, float yPoint, int price, int speed, int year) : base(xPoint, yPoint, price,
            speed, year)
        {
        }

        /// <summary>
        /// Конструктор корабля
        /// </summary>
        /// <param name="price">Цена Коробля</param>
        /// <param name="speed">Скорость Коробля</param>
        /// <param name="year">Год выпуска Коробля</param>
        public Ship(int price, int speed, int year) : base(price, speed, year)
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

        /// <summary>
        /// Поле порт
        /// </summary>
        private string _port;

        /// <summary>
        /// Свойство порт 
        /// </summary>
        public string Port
        {
            get
            {
                if (_port == null)
                    return "Порт не задан";
                return _port;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Значение пустое");
                }
                else
                {
                    _port = value;
                }
            }
        }
    }
}
