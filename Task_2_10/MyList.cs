namespace Task_2_10
{
    /// <summary>
    /// Класс коллекцуии MyList
    /// </summary>
    /// <typeparam name="T">Обощённый тип</typeparam>
    public class MyList<T> : IMyList<T>
    {
        /// <summary>
        /// Поле массива обобщённого типа
        /// </summary>
        private T[] _array;

        /// <summary>
        /// Конструктор для новой коллекции
        /// </summary>
        public MyList()
        {
            _array = new T[0];
        }

        /// <summary>
        /// Индексатор коллекции
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <returns></returns>
        public T this[int index] => _array[index] ;

        /// <summary>
        /// Метод для поулчения длинны массива
        /// </summary>
        public int Counter => _array.Length;

        /// <summary>
        /// Метод для добавления нового элемента в коллекцию MyList
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            T[] tempArray = new T[_array.Length + 1]; // Создание временного массив с заполнения типом с размерностью увеличеной на +1

            for (int i = 0; i<_array.Length; i++)
            {
                tempArray[i] = _array[i]; //Корирование элементов массива в временный массив
            }
            tempArray[_array.Length] = item; //Добавление нового элемента в конец массива
            _array = tempArray; //Присвоение переменной array ссылки на массив tempArray
        }

        /// <summary>
        /// Метод удаления массива
        /// </summary>
        public void Remove()
        {
            _array = new T[0];
        }

        /// <summary>
        /// Переопределение медода ToString базового класса object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string str = null; //Создание локальной переменной строкового типа
            for (int i = 0; i < _array.Length; i++)
            {
                str += _array[i] + " "; //Запись каждого элемента массива в локальную переменную
            }
            return "Размерность массива " + _array.Length + " Элементы массива:" + str;
        }
    }
}
