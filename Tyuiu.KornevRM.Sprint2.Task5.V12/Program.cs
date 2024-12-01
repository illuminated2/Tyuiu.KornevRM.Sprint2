using Tyuiu.KornevRM.Sprint2.Task5.V12.Lib;

namespace Tyuiu.KornevRM.Sprint2.Task5.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Корнев Р.М. | ИСПб-24-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Оператор switch                                                             *");
            Console.WriteLine("* Задание #5                                                                        *");
            Console.WriteLine("* Вариант #12                                                                       *");
            Console.WriteLine("* Выполнил: Корнев Р.М. | ИСПб-24-1                                                 *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Задание:                                                                          *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет                  *");
            Console.WriteLine("* требуемое значение и возвращает результат.                                        *");
            Console.WriteLine("* Условие:                                                                          *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:                   *");
            Console.WriteLine("* m(порядковый номер месяца) и n(число).По заданным g, n и m определить             *");
            Console.WriteLine("* дату предыдущего дня.Заданный год является високосным.                            *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");
    
            Console.WriteLine("Введите год:");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                         *");
            Console.WriteLine("*************************************************************************************");

            string res = Convert.ToString(ds.FindDateOfPreviousDay(g, m, n));
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
