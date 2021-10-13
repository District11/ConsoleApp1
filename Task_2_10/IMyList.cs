namespace Task_2_10
{
    /// <summary>
    /// Интерфейс MyList
    /// </summary>
    interface IMyList<T>
    {
        /// <summary>
        /// Добавление элемента в массив
        /// </summary>
        /// <param name="item">Новый элемент массива</param>
        void Add(T item);

        /// <summary>
        /// Индексатор массива
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <returns></returns>
        T this[int index] { get; }
        
        /// <summary>
        /// Метод для получения длинны массива
        /// </summary>
        int Counter { get; }

        /// <summary>
        /// Метод удаления массива
        /// </summary>
        void Remove();
    }
}
