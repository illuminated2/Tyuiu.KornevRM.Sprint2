using Tyuiu.KornevRM.Sprint2.Task7.V7.Lib;
namespace Tyuiu.KornevRM.Sprint2.Task7.V7
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
            Console.WriteLine("Введите значение переменной Y");
            double y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("***********************************************************************");

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
