using Tyuiu.KornevRM.Sprint2.Task4.V9.Lib;

namespace Tyuiu.KornevRM.Sprint2.Task4.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Корнев Р.М. | ИСПб-24-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Тернарный оператор                                                          *");
            Console.WriteLine("* Задание #4                                                                        *");
            Console.WriteLine("* Вариант #9                                                                        *");
            Console.WriteLine("* Выполнил: Корнев Р.М. | ИСПб-24-1                                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с использованием         *");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значение переменных x,y с           *");
            Console.WriteLine("* клавиатуры, если x - 20 * 2 < y / 4 , то                                          *");
            Console.WriteLine("* z = ( 3 + 8 / x^2) ^ y иначе y - ( x + 1 / y + 2) ^ x                             *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");
           

            Console.WriteLine("Введите значение переменной X");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y");
            double y = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x,y);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                         *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();

        }
    }
}
