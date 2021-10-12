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

            Converter converter = new Converter(26.58, 30.98, 0.37);
            string number1 = Console.ReadLine();
            if (int.TryParse(number1, out int number))
            {
                double sum;
                Console.WriteLine("Введите количество сумму для конвертации: ");
                string sumInput = Console.ReadLine();
                if(double.TryParse(sumInput,out sum))
                {
                    switch (number)
                    {
                        case 1:
                            converter.ConvertToEur(sum);
                            break;
                        case 2:
                            converter.ConvertToUsd(sum);
                            break;
                        case 3:
                            converter.ConvertToRub(sum);
                            break;
                        case 4:
                            converter.ConvertFromEur(sum);
                            break;
                        case 5:
                            converter.ConvertFromUsd(sum);
                            break;
                        case 6:
                            converter.ConvertFromRub(sum);
                            break;
                        default:
                            Console.WriteLine("Повторите ввод");
                            break;
                    }
                }               
            }
        }
    }
}