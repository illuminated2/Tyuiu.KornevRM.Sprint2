using Tyuiu.KornevRM.Sprint2.Task7.V7.Lib;
namespace Tyuiu.KornevRM.Sprint2.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
             DataService ds = new DataService();
            double x = 1;
            double y = 1;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true,res);

        }
    }
}