using Tyuiu.SchcapovMA.Sprint3.Task2.V2.Lib;
namespace Tyuiu.SchcapovMA.Sprint3.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 7;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 6482.439;
            Assert.AreEqual(res, wait);
        }
    }
}