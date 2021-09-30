using System;

namespace Task_4
{
    /// <summary>
    /// Класс конвертёра
    /// </summary>
    public class Converter
    {
        /// <summary>
        /// 
        /// </summary>
        public double _usd, _eur, _rub, sum;

        /// <summary>
        /// Метод для конвертации валюты
        /// </summary>
        /// <param name="usd"></param>
        /// <param name="eur"></param>
        /// <param name="rub"></param>
        public Converter(double usd, double eur, double rub)
        {
            //Инциализация валюты
            this._usd = usd;
            this._eur = eur;
            this._rub = rub;
        }

        public void ConvertToUsd(double sum)
        {
            double result;
            result = sum / _usd;
            Console.WriteLine($"{result} Долларов");

        }
        public void ConvertFromUsd(double sum)
        {
            double result;
            result = sum * _usd;
            Console.WriteLine($"{result} Гривнов");
        }
        public void ConvertToRub(double sum)
        {
            double result;
            result = sum / _rub;
            Console.WriteLine($"{result} Рублей");
        }
        public void ConvertFromRub(double sum)
        {
            double result;
            result = sum * _rub;
            Console.WriteLine($"{result} Гривнов");
        }
        public void ConvertToEur(double sum)
        {
            double result;
            result = sum * _eur;
            Console.WriteLine($"{result} Евро");
        }
        public void ConvertFromEur(double sum)
        {
            double result;
            result = sum / _eur;
            Console.WriteLine($"{result} Гривнов");
        }
    }
}