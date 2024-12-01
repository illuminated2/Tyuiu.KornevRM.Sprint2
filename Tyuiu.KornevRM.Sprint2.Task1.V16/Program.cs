using Tyuiu.KornevRM.Sprint2.Task1.V16.Lib;
namespace Tyuiu.KornevRM.Sprint2.Task1.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Корнев Р.М. | ИСПб-24-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Логические операции                                                         *");
            Console.WriteLine("* Задание #1                                                                        *");
            Console.WriteLine("* Вариант #16                                                                       *");
            Console.WriteLine("* Выполнила: Корнев Р.М. | ИСПб-24-1                                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,                   *");
            Console.WriteLine("* можно чередовать, но использовать один раз в выражении) и логических операций     *");
            Console.WriteLine("* (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также   *");
            Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность(массив):   *");
            Console.WriteLine("* (True, False, False, False, False, False), при a = 145, b = 716, c = 144, d = 137 *");
            Console.WriteLine("*                                                                                   *");
            int a = 145;
            int b = 716;
            int c = 144;
            int d = 137;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("************************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("***********************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
