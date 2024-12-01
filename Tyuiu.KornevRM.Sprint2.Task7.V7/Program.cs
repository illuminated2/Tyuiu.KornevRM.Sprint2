using Tyuiu.KornevRM.Sprint2.Task7.V7.Lib;
namespace Tyuiu.KornevRM.Sprint2.Task7.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Корнев Р.М. | ИСПб-24-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                           *");
            Console.WriteLine("* Задание #7                                                                        *");
            Console.WriteLine("* Вариант #7                                                                       *");
            Console.WriteLine("* Выполнил: Корнев Р.М. | ИСПб-24-1                                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные                     *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами X,Y        *");
            Console.WriteLine("* в заштрихованной области.                                                         *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Введите значение переменной X");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y");
            double y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                         *");
            Console.WriteLine("*************************************************************************************");

            if (res)
            {
                Console.WriteLine("точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("точка не находится в заштрихованной области");
            }
            Console.ReadKey();
        }
    }
}
