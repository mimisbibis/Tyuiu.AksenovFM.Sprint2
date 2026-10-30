using Tyuiu.AksenovFM.Sprint2.Task6.V1.Lib;

namespace Tyuiu.AksenovFM.Sprint2.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthDaysCount()
        {
            DataService ds = new DataService();

            Assert.AreEqual(31, ds.FindMonthDaysCount(1));
            Assert.AreEqual(28, ds.FindMonthDaysCount(2));
            Assert.AreEqual(30, ds.FindMonthDaysCount(4));
            Assert.AreEqual(31, ds.FindMonthDaysCount(12));
        }
    }
}