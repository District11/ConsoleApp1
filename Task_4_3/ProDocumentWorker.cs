using System;

namespace Task_4_3
{
    /// <summary>
    /// Класс ProDocumenWorker
    /// </summary>
    public class ProDocumentWorker:DocumentWorker
    {
        /// <summary>
        /// Метод редактирования в версии Про
        /// </summary>
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        /// <summary>
        /// Метод сохранения в версии Про
        /// </summary>
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
}