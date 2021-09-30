using System;

namespace Task_3_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Создание экземпляра
            Employee employee = new Employee("Борис", "Бритва");
            employee.Position = "manager";
            employee.Expirience = 1; 

            //Вывод результата
            Console.WriteLine(employee.Surname + " " + employee.Name + " " + employee.Position);
            employee.ShowPay();

            Console.ReadKey();
        }
    }
}
