using Tyuiu.KornevRM.Sprint2.Task6.V7.Lib;
namespace Tyuiu.KornevRM.Sprint2.Task6.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*ИСКХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("Введите год:");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сколько месяцев прошло:");
            int m = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("***********************************************************************");

            Console.WriteLine(ds.FindMonthName(g, m));
            Console.ReadKey();
        }
    }
}
