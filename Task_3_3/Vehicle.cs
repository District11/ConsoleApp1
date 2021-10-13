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
        /// 
        /// </summary>
        /// <param name="price">Цена транспорта</param>
        /// <param name="speed">Скорость транспорта</param>
        /// <param name="year">Год выпуска транспорта</param>
        public Vehicle(int price, int speed, int year) : this(0, 0, price, speed, year)
        {

        }
    }

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