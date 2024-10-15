using Tyuiu.KornevRM.Sprint2.Task6.V7.Lib;
namespace Tyuiu.KornevRM.Sprint2.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 5;
            int startYear = 1990;
            string res = ds.FindMonthName(startYear, n);
            string wait = "θώνό";
            Assert.AreEqual(wait, res);


        }
    }
}