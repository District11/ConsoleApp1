using System;

namespace Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            BadPupil p1 = new BadPupil();
            ExcelentPupil p2 = new ExcelentPupil();
            GoodPupil p3 = new GoodPupil();
            ClassRoom group = new ClassRoom(p1,p2,p3); //Создание экземпляра класса ClassRoom

            group.Study();
            Console.WriteLine(new string('-', 30));
            group.Read();
            Console.WriteLine(new string('-', 30));
            group.Write();
            Console.WriteLine(new string('-', 30));
            group.Relax();
        }
    }
}