using Tyuiu.SchcapovMA.Sprint3.Task0.V5.Lib;
namespace Tyuiu.SchcapovMA.Sprint3.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = 81.083;
            Assert.AreEqual(res, wait);
        }
    }
}