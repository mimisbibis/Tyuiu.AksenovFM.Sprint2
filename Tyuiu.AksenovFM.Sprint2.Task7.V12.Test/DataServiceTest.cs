using Tyuiu.AksenovFM.Sprint2.Task7.V12.Lib;
namespace Tyuiu.AksenovFM.Sprint2.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            Assert.IsTrue(ds.CheckDotInShadedArea(-3, 6)); Assert.IsTrue(ds.CheckDotInShadedArea(1, 0.5));
            Assert.IsFalse(ds.CheckDotInShadedArea(-1, 6));
            Assert.IsFalse(ds.CheckDotInShadedArea(0.5, 1));
        }
    }
}