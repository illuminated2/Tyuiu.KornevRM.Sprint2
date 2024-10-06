using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
using Tyuiu.KornevRM.Sprint2.Task1.V16.Lib;
namespace Tyuiu.KornevRM.Sprint2.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 145;
            int b = 716;
            int c = 144;
            int d = 137;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = { true, true, true, false, true, false };

            CollectionAssert.AreEqual(res, wait);   

        }
    }
}