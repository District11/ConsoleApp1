using System;

namespace Task_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ключ для получения доступа к версии Pro или Expert: ");
            string key = Console.ReadLine();
            DocumentWorker documentWorker = null;
            //Услованя конструкция для выбора версии
            switch (key.ToLower())
            {
                case "pro":
                    documentWorker = new ProDocumentWorker();
                    break;
                case "expert":
                    documentWorker = new ExpertDocumentWorker();
                    break;
                default:
                    documentWorker = new DocumentWorker();
                    break;
            }
            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();
        }
    }
}