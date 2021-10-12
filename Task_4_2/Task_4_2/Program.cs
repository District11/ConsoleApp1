using System;

namespace Task_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(678904, "Azat", "SushiBoks") {Article = "fobo", Quantity = 6};

            invoice.CalculationByOrder(true); //Вызов метода CalculationByOrder где НДС нужен
            invoice.CalculationByOrder(false); //Вызов метода CalculationByOrder где НДС не нужен
        }
    }
}