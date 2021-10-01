using System;

namespace Task_4
{
    /// <summary>
    /// Класс конвертёра
    /// </summary>
    public class Converter
    {
        /// <summary>
        /// Поля валют
        /// </summary>
       private double _usd, _eur, _rub, sum;

        /// <summary>
        /// Конструктор для валюты
        /// </summary>
        /// <param name="usd">Доллар</param>
        /// <param name="eur">Евро</param>
        /// <param name="rub">Рубли</param>
        public Converter(double usd, double eur, double rub)
        {
            //Инциализация валюты
            this._usd = usd;
            this._eur = eur;
            this._rub = rub;
        }

        /// <summary>
        /// Метод для конвертирования из гривнов в доллары
        /// </summary>
        /// <param name="sum">Доллары</param>
        public void ConvertToUsd(double sum)
        {
            double result;
            result = sum / _usd;
            Console.WriteLine($"{result} Долларов");

        }

        /// <summary>
        /// Метод для конвертирования из долларов в гривны 
        /// </summary>
        /// <param name="sum">гривны</param>
        public void ConvertFromUsd(double sum)
        {
            double result;
            result = sum * _usd;
            Console.WriteLine($"{result} Гривнов");
        }

        /// <summary>
        /// Метод для конвертирования из гривнов в рубли
        /// </summary>
        /// <param name="sum">Рубли</param>
        public void ConvertToRub(double sum)
        {
            double result;
            result = sum / _rub;
            Console.WriteLine($"{result} Рублей");
        }

        /// <summary>
        /// Метод для конвертирования из рублей в гривны 
        /// </summary>
        /// <param name="sum">Гривны</param>
        public void ConvertFromRub(double sum)
        {
            double result;
            result = sum * _rub;
            Console.WriteLine($"{result} Гривнов");
        }

        /// <summary>
        /// Метод для конвертирования из гривнов в евро
        /// </summary>
        /// <param name="sum">Евро</param>
        public void ConvertToEur(double sum)
        {
            double result;
            result = sum * _eur;
            Console.WriteLine($"{result} Евро");
        }

        /// <summary>
        /// Метод для конвертирования из евро в гривны
        /// </summary>
        /// <param name="sum">Гривны</param>
        public void ConvertFromEur(double sum)
        {
            double result;
            result = sum / _eur;
            Console.WriteLine($"{result} Гривнов");
        }
    }
}