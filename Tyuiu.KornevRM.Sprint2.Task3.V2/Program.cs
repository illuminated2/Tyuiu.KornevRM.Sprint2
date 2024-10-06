using Tyuiu.KornevRM.Sprint2.Task3.V2.Lib;

namespace Tyuiu.KornevRM.Sprint2.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*ИСКХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");

            Console.WriteLine("Введите значение переменной X");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("***********************************************************************");

            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();
        }
    }
}
