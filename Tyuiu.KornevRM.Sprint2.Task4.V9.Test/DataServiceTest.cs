using Tyuiu.KornevRM.Sprint2.Task4.V9.Lib;

namespace Tyuiu.KornevRM.Sprint2.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 15;
            double res = ds.Calculate(x, y);
            double wait = 9999.8;
            Assert.AreEqual(res, wait);


        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 623.5;
            Assert.AreEqual(res, wait);

        }
    }
}