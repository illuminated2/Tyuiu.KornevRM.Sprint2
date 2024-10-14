using Tyuiu.KornevRM.Sprint2.Task5.V12.Lib;

namespace Tyuiu.KornevRM.Sprint2.Task5.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Корнев Р.М. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Корнев Руслан Максимвоич    | ИСПб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: Дата некоторого дня характеризуется тремя натуральными числами:*");
            Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число). По заданным g, n и m  *");
            Console.WriteLine("* определить дату предыдущего дня. Заданный год не является високосным.   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите год:");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Результат: " + ds.FindDateOfPreviousDay(g, m, n));
            Console.ReadKey();
        }
    }
}
