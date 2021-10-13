using System;

namespace Task_4_3
{
    /// <summary>
    /// Класс ExpertDocument
    /// </summary>
    public class ExpertDocumentWorker:ProDocumentWorker
    {
        /// <summary>
        /// Метод для сохранения документа в версии ExpertDocument
        /// </summary>
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}