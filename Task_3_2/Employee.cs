using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_2
{
    /// <summary>
    /// Класс сотрудника
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Поля информации о имени и фимилии сотрудника
        /// </summary>
        private readonly string _name, _surname;

        /// <summary>
        /// Поле об опыте сотрудника
        /// </summary>
        private double _expirience;

        /// <summary>
        /// Поле информации о позиции сотрудника
        /// </summary>
        private string _position;

        /// <summary>
        /// Пользовательский конструктор сотрудника
        /// </summary>
        /// <param name="name">Имя сотрудника</param>
        /// <param name="surename">Фамилия сотрудника</param>
        public Employee(string name, string surname)
        {
            this._name = name;
            this._surname = surname;
        }

        /// <summary>
        /// Свойство для получения имени сотрудника
        /// </summary>
        /// <returns></returns>
        public string Name => _name;

        /// <summary>
        /// Свойство для получения фамилии сотрудника
        /// </summary>
        /// <returns></returns>
        public string Surname => _surname;

        /// <summary>
        /// Свойство для позиции сотрудника
        /// </summary>
        public string Position
        {
            //Получение информации о позиции сотрудника
            get
            {
                if (_position == null)
                {
                    return "Должность у данного сотрудника неизвестна";
                }
                return _position;
            }
            //Внесение данных о позиции сотрудника
            set
            {
                if (value != null)
                    _position = value;
            }
        }

        /// <summary>
        /// Свойство для опыта сотрудника
        /// </summary>
        public double Expirience
        {
            // получение информации о стаже сотрудника
            get => _expirience;

            // внесение информации о стаже сотрудника
            set
            {
                if (_expirience >= 0)
                {
                    _expirience = value;
                }
            }
        }

        /// <summary>
        /// Метод для расчёта оклада сотрудника
        /// </summary>
        /// <param name="position">Позиция сотрудника</param>
        /// <param name="expirience">Опыт сотрудника</param>
        public double PayToEmployee()
        {
            double sumPay;
            switch (_position.ToLower())
            {
                case "Qa":
                    sumPay = 400000;
                    break;
                case "developer":
                    sumPay = 600000;
                    break;
                case "manager":
                    sumPay = 500000;
                    break;
                case "cleaner":
                    sumPay = 65000;
                    break;
                default:
                    sumPay = 100000;
                    break;
            }
            switch (_expirience)
            {
                case 1:
                    sumPay *= 1.5;
                    break;
                case 2:
                    sumPay *= 2;
                    break;
                case 3:
                    sumPay *= 2.5;
                    break;
                case 4:
                    sumPay *= 5;
                    break;
            }
            return sumPay;
        }

        /// <summary>
        /// Метод для выведения информации о сотруднике
        /// </summary>
        public void ShowPay()
        {
            Console.WriteLine("Зарплата сотрудника {0} \nПодоходный налог {1}", PayToEmployee(), PayToEmployee() * 0.13);
        }
    }
}
