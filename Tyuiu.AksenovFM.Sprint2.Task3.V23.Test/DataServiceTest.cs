using Tyuiu.AksenovFM.Sprint2.Task3.V23.Lib;

namespace Tyuiu.AksenovFM.Sprint2.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate_FirstCondition()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 18;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate_SecondCondition()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = -5.333;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate_ThirdCondition()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = 4;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate_FourthCondition()
        {
            DataService ds = new DataService();
            double x = -28;
            double wait = -308.001;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}