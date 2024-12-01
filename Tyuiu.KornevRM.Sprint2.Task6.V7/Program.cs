using Tyuiu.KornevRM.Sprint2.Task6.V7.Lib;
namespace Tyuiu.KornevRM.Sprint2.Task6.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Корнев Р.М. | ИСПб-24-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Получение результата из switch                                              *");
            Console.WriteLine("* Задание #6                                                                        *");
            Console.WriteLine("* Вариант #7                                                                        *");
            Console.WriteLine("* Выполнила: Корнев Р.М. | ИСПб-24-1                                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Задание:                                                                          *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи оператора switch  *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                              *");
            Console.WriteLine("* Условие: С начала 1990 года по некоторый день прошло n месяцев и 2 дня.           *");
            Console.WriteLine("* Определить название месяца (январь, февраль и т. п.) этого дня.                   *");                                  
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("Введите год:");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сколько месяцев прошло:");
            int m = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                         *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine(ds.FindMonthName(g, m));
            Console.ReadKey();
        }
    }
}
