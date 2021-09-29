using System;

namespace Task_4
{
    public class Converter
    {
        public double _usd { get; set; }
        public double _eur { get; set; }
        public double _rub { get; set; }
        public double _uah { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usd"></param>
        /// <param name="eur"></param>
        /// <param name="rub"></param>
        public ConverterTo(double usd, double eur, double rub)
        {
            this._usd = 26.54 ;
            this._eur = 31.04;
            this._rub = 0.37;
        }

        public void Info()
        {
            Console.WriteLine($"Ваши гривны: {_uah} = EUR:{_eur}, USD:{_usd}, RUB:{_rub}");
        }
    }
}