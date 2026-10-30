using Tyuiu.AksenovFM.Sprint2.Task6.V1.Lib;

namespace Tyuiu.AksenovFM.Sprint2.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindAmountDaysInMonth()
        {
            DataService ds = new DataService();

            Assert.AreEqual(31, ds.FindAmountDaysInMonth(1));
            Assert.AreEqual(28, ds.FindAmountDaysInMonth(2));
            Assert.AreEqual(30, ds.FindAmountDaysInMonth(4));
            Assert.AreEqual(31, ds.FindAmountDaysInMonth(12));
        }
    }
}