using Tyuiu.AksenovFM.Sprint2.Task4.V4.Lib;

namespace Tyuiu.AksenovFM.Sprint2.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 10;
            double wait = 20.841;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double wait = 100.284;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}