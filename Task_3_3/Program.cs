using System;
using System.Numerics;

namespace Task_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание экземпляра класса Корабль с передачей значений в пользовательский конструктор
            Ship ship = new Ship(20000, 120, 2000)
            {
                Passengers = 28,
                Port = "Санкт-Петербург" 
            };

            //Создание экземпляра класса Машина
            Car car = new Car(150000, 2000, 2012);

            // Создание экземпляра класса самолёт с передачей значений в пользовательский конструктор
            Plane plane = new Plane(100000, 3000, 2021)
            {
                Passengers = 12
            };


            Console.WriteLine("Цена корабля {0}, скорость {1}, год выпуска {2}, количество пасажиров {3}, порт приписки {4}", ship.Price, ship.Speed, ship.Year, ship.Passengers, ship.Port);
            Console.WriteLine("Цена Машины {0}, скорость {1}, год выпуска {2}", car.Price, car.Speed, car.Year);
            Console.WriteLine("Цена Самолёта {0}, скорость {1}, год выпуска {2}, количество пасажиров {3}", plane.Price, plane.Speed, plane.Year, plane.Passengers);
        }
    }
}