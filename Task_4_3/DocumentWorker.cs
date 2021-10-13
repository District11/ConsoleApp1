using System;

namespace Task_4_3
{
    /// <summary>
    /// Класс DocumentWorker
    /// </summary>
    public class DocumentWorker
    {
        /// <summary>
        /// Метод открытия документа
        /// </summary>
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        /// <summary>
        /// Метод редактирования документа
        /// </summary>
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }

        /// <summary>
        /// Метод сохранеия документа 
        /// </summary>
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
}