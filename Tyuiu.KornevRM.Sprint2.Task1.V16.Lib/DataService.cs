
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KornevRM.Sprint2.Task1.V16.Lib
{
    public class DataService : ISprint2Task1V16
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (c > d);
            res[1] = (c <= a) & (d != b);
            res[2] = (c < a) || (d != b);
            res[3] = (c > a) && (d != b);
            res[4] = !(res[3]);
            res[5] = (a > c) ^ (b > d);
            return res;
        }
       
    }
}
