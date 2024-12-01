using Tyuiu.KornevRM.Sprint2.Task3.V2.Lib;

namespace Tyuiu.KornevRM.Sprint2.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Корнев Р.М. | ИСПб-24-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                               *");
            Console.WriteLine("* Задание #3                                                                        *");
            Console.WriteLine("* Вариант #2                                                                        *");
            Console.WriteLine("* Выполнил: Корнев Р.М. | ИСПб-24-1                                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с              *");
            Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит значение       *");
            Console.WriteLine("* переменной X с клавиатуры. Округлить полученное значение до трех знаков           *");
            Console.WriteLine("* после запятой                                                                     *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("Введите значение переменной X");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("************************************************************************************");

            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();
        }
    }
}
