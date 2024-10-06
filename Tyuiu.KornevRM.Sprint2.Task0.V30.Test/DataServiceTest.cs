using Tyuiu.KornevRM.Sprint2.Task0.V30.Lib;
namespace Tyuiu.KornevRM.Sprint2.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 95;
            int y = 1735;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = { true, false, true, false, true, false };

            CollectionAssert.AreEqual(res, wait);
        }
    }
}