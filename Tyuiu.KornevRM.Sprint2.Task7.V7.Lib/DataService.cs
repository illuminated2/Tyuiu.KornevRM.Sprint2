using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KornevRM.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if(y == x)
            {
                return true;
                
            }
            if (2 - Math.Pow(x, 2) == y)
            {
                return true;

            }
            else
            {
                return false;
            }
            return res;
        }
    }
}
