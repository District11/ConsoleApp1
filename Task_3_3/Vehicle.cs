using System;

namespace Task_3_3
{
    /// <summary>
    /// Класс транспорта
    /// </summary>
    public class Vehicle
    {

        /// <summary>
        /// Поле кооординаты X
        /// </summary>
        private float _XPoint;

        /// <summary>
        /// Свойство координаты Х
        /// </summary>
        public float XPoint => _XPoint;

        /// <summary>
        /// Поле кооординаты Y
        /// </summary>
        private float _YPoint;

        /// <summary>
        /// Свойство кооординаты Y
        /// </summary>
        public float YPoint => _YPoint;

        /// <summary>
        /// Поле цена
        /// </summary>
        private int _price;

        /// <summary>
        /// Свойство цены
        /// </summary>
        public int Price => _price;

        /// <summary>
        /// Поле скорости
        /// </summary>
        private int _speed;

        /// <summary>
        /// Свойство скорости
        /// </summary>
        public int Speed => _speed;

        /// <summary>
        /// Поле года выпуска
        /// </summary>
        private int _year;

        /// <summary>
        /// Свойство года выпуска
        /// </summary>
        public int Year => _year;


        /// <summary>
        /// Конструктор для траспорта
        /// </summary>
        /// <param name="xPoint">Координата х</param>
        /// <param name="yPoint">Координата у</param>
        /// <param name="price">Цена транспорта</param>
        /// <param name="speed">Скорость транспорта</param>
        /// <param name="year">Год выпуска транспорта</param>
        public Vehicle(float xPoint, float yPoint, int price, int speed, int year)
        {
            this._XPoint = xPoint;
            this._YPoint = yPoint;
            this._price = price;
            this._speed = speed;
            this._year = year;
        }

        /// <summary>
        /// Конструктор для транспорта
        /// </summary>
        /// <param name="price">Цена транспорта</param>
        /// <param name="speed">Скорость транспорта</param>
        /// <param name="year">Год выпуска транспорта</param>
        public Vehicle(int price, int speed, int year) : this(0, 0, price, speed, year)
        {

        }
    }
}