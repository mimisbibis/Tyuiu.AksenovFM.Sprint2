using Tyuiu.AksenovFM.Sprint2.Task5.V10.Lib;

namespace Tyuiu.AksenovFM.Sprint2.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual("14.05.2023", ds.FindDateOfPreviousDay(2023, 5, 15));
            Assert.AreEqual("30.04.2023", ds.FindDateOfPreviousDay(2023, 5, 1));
            Assert.AreEqual("28.02.2024", ds.FindDateOfPreviousDay(2024, 3, 1));
            Assert.AreEqual("31.12.2022", ds.FindDateOfPreviousDay(2023, 1, 1));
            Assert.AreEqual("07.09.2023", ds.FindDateOfPreviousDay(2023, 9, 8));
        }
    }
}