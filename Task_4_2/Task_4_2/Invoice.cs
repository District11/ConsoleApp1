using System;

namespace Task_4_2
{
    /// <summary>
    /// Класс накладной
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// Учётная запись пользователя
        /// </summary>
        public readonly int account = 0;
        
        /// <summary>
        /// Заказчик
        /// </summary>
        public readonly string customer = null;
        
        /// <summary>
        /// Поставщик
        /// </summary>
        public readonly string provider = null;

        /// <summary>
        /// Свойство товара
        /// </summary>
        public string Article { get; set; }
        
        /// <summary>
        /// Свойство количества товара
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Конструктор Накладной
        /// </summary>
        /// <param name="account">Учётная запись пользователя</param>
        /// <param name="customer">Заказчик</param>
        /// <param name="provider">Поставщик</param>
        public Invoice(int account, string customer, string provider)
        {
            //Инциализация полей
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        
        /// <summary>
        /// Метод для росчёта товара
        /// </summary>
        /// <param name="neededNDS">необходимость НДС</param>
        public void CalculationByOrder(bool neededNDS)
        {
            double sum;
            switch (Article.ToLower())
            {
                case "pizza":
                    sum = 400;
                    break;

                case "fobo":
                    sum = 250;
                    break;

                case "rolls":
                    sum = 280;
                    break;

                case "steak":
                    sum = 2500;
                    break;
                default:
                    Console.WriteLine("Нет такого блюда");
                    return;
            }
            if (neededNDS)
            {
                double sum1, sum2;
                sum1 = (sum + (sum * 20 / 120)) * Quantity;
                sum2 = sum * Quantity;
                Console.WriteLine($"Сумма c НДС {sum1} " +
                                  $"\nСумма без Ндс {sum2}" );
            }
            
        }
    }
}