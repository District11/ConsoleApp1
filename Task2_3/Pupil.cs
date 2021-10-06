using System;

namespace Task2_3
{
    /// <summary>
    /// Класс учеников
    /// </summary>
    public class Pupil
    {
        /// <summary>
        /// Виртуальный метод иметирующий учёбу ученика
        /// </summary>
        public virtual void Study()
        {
            Console.WriteLine("Ученики учатся");
        }

        /// <summary>
        /// Виртуальный метод иметирующий чтение ученика
        /// </summary>
        public virtual void Read()
        {
            Console.WriteLine("Ученики читают");
        }

        /// <summary>
        /// Виртуальный метод иметирующий письменную деятельность ученика
        /// </summary>
        public virtual void Write()
        {
            Console.WriteLine("Ученики пишут");
        }

        /// <summary>
        /// Виртуальный метод иметирующий отдых ученика
        /// </summary>
        public virtual void Relax()
        {
            Console.WriteLine("Ученики отдыхают");
        }
    }

    /// <summary>
    /// Класс отличников
    /// </summary>
    public class ExcelentPupil : Pupil
    {
        /// <summary>
        /// Переопределённый метод иметирующий учёбу ученика
        /// </summary>
        public override void Study()
        {
            Console.WriteLine("Отличники учатся");
        }

        /// <summary>
        /// Переопределённый метод иметирующий чтение ученика
        /// </summary>
        public override void Read()
        {
            Console.WriteLine("Отличники читают");
        }

        /// <summary>
        /// Переопределённый метод иметирующий письменную деятельность ученика
        /// </summary>
        public override void Write()
        {
            Console.WriteLine("Отличники пишут");
        }

        /// <summary>
        /// Переопределённый метод иметирующий отдых ученика
        /// </summary>
        public override void Relax()
        {
            Console.WriteLine("Отличники отдыхают");
        }
    }

    /// <summary>
    /// Класс хорошистов
    /// </summary>
    public class GoodPupil : Pupil
    {
        /// <summary>
        /// Переопределённый метод иметирующий учёбу хорошиста
        /// </summary>
        public override void Study()
        {
            Console.WriteLine("Хорошисты учатся");
        }

        /// <summary>
        /// Переопределённый метод иметирующий чтение хорошиста
        /// </summary>
        public override void Read()
        {
            Console.WriteLine("Хорошисты читают");
        }

        /// <summary>
        /// Переопределённый метод иметирующий письменную деятельность хорошиста
        /// </summary>
        public override void Write()
        {
            Console.WriteLine("Хорошисты пишут");
        }

        /// <summary>
        /// Переопределённый метод иметирующий отдых хорошиста
        /// </summary>
        public override void Relax()
        {
            Console.WriteLine("Хорошисты отдыхают");
        }
    }
    
    /// <summary>
    /// Класс плохишей
    /// </summary>
    public class BadPupil : Pupil
    {
        /// <summary>
        /// Переопределённый метод иметирующий учёбу плохиша
        /// </summary>
        public override void Study()
        {
            Console.WriteLine("Плохиши учатся");
        }

        /// <summary>
        /// Переопределённый метод иметирующий чтение плохиша
        /// </summary>
        public override void Read()
        {
            Console.WriteLine("Плохиши читают");
        }

        /// <summary>
        /// Переопределённый метод иметирующий письменную деятельность плохиша
        /// </summary>
        public override void Write()
        {
            Console.WriteLine("Плохиши пишут");
        }

        /// <summary>
        /// Переопределённый метод иметирующий отдых плохиша
        /// </summary>
        public override void Relax()
        {
            Console.WriteLine("Плохиши отдыхают");
        }
    }
}