using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Выберите действие: конвертация гривны в:" +
                              "\n1. Конвертация гривны в Евро " +
                              "\n2. Конвертация гривны в Доллары " +
                              "\n3. Конвертация гривны в Рубли" +
                              "\n4. Конвертация Евро из гривны " +
                              "\n5. Конвертация Доллары из гривны" +
                              "\n6. Конвертация Рубля из гривны ");
            
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество гривен");
            Converter converter = new Converter(0.038, 0.032, 2.73);
            Converter converter1 = new Converter(Convert.ToDouble(Console.ReadLine()));
            switch (number)
            {
                case 1:
                    converter1._eur = converter._eur * converter1._uah;
                    converter1.Info();
                    break;
                case 2:
                    converter1._usd = converter._usd * converter1._uah;
                    converter1.Info();
                    break;
                case 3:
                    converter1._rub = converter._rub * converter1._uah;
                    converter1.Info();
                    break;
                case 4:
                    converter._eur = converter1._uah / converter._eur;
                    converter1.Info();
                    break;
                case 5:
                    converter._usd = converter1._uah / converter._usd;
                    converter1.Info();
                    break;
                case 6:
                    converter._rub = converter1._uah / converter._rub;
                    converter1.Info();
                    break;
                default:
                    Console.WriteLine("Повторите ввод");
                    break;
            }
        }
    }
}