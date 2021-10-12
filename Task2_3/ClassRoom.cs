using System;

namespace Task2_3
{
    /// <summary>
    /// Класс Кабинета
    /// </summary>
    public class ClassRoom
    {
        /// <summary>
        /// Создание экземпляра генератора случайных чисел
        /// </summary>
        public Random random = new Random();

        /// <summary>
        /// Создание массива из 4 элементов
        /// </summary>
        private Pupil[] _pupils = new Pupil[4];

        /// <summary>
        /// Конструктор принимающий экземпляры класса Pupil 
        /// </summary>
        /// <param name="p1">1-й Элемент массива</param>
        /// <param name="p2">2-й Элемент массива</param>
        public ClassRoom(Pupil p1, Pupil p2)
        {
            _pupils[0] = p1;
            _pupils[1] = p2;
            _pupils[2] = GeneratePupil();
            _pupils[3] = GeneratePupil();
        }

        /// <summary>
        /// Перегрузка конструктора принимающий экземпляры класса Pupil
        /// </summary>
        /// <param name="p1">1-й Элемент массива</param>
        /// <param name="p2">2-й Элемент массива</param>
        /// <param name="p3">3-й Элемент массива</param>
        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
        {
            _pupils[0] = p1;
            _pupils[1] = p2;
            _pupils[2] = p3;
            _pupils[3] = GeneratePupil();
        }

        /// <summary>
        /// Перегрузка конструктора принимающий экземпляры класса Pupil
        /// </summary>
        /// <param name="p1">1-й Элемент массива</param>
        /// <param name="p2">2-й Элемент массива</param>
        /// <param name="p3">3-й Элемент массива</param>
        /// <param name="p4">4-й Элемент массива</param>
        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            _pupils[0] = p1; //Заполнение массива по индексу
            _pupils[1] = p2;
            _pupils[2] = p3;
            _pupils[3] = p4;
        }

        /// <summary>
        /// Метод для генерации учеников
        /// </summary>
        /// <returns></returns>
        private Pupil GeneratePupil()
        {
            //случайная генерация учеников от 1 до 4
            int randomPupil = random.Next(1, 4);

            switch (randomPupil)
            {
                case 1: return new ExcelentPupil();
                case 2: return new GoodPupil();
                case 3: return new BadPupil();
                default:
                    return new BadPupil();
            }
        }

        /// <summary>
        /// Метод для обучения
        /// </summary>
        public void Study()
        {
            foreach (Pupil p in _pupils)
            {
                p.Study(); 
            }
        }

        /// <summary>
        /// Метод для написания
        /// </summary>
        public void Write()
        {
            foreach (Pupil p in _pupils)
            {
                p.Write();
            }
        }

        /// <summary>
        /// Метод для чтения
        /// </summary>
        public void Read()
        {
            foreach (Pupil p in _pupils)
            {
                p.Read();
            }
        }

        /// <summary>
        /// Метод для раслабления
        /// </summary>
        public void Relax()
        {
            foreach (Pupil p in _pupils)
            {
                p.Relax();
            }
        }
    }
}