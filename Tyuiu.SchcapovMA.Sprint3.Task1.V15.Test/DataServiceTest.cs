using Tyuiu.SchcapovMA.Sprint3.Task1.V15.Lib;
namespace Tyuiu.SchcapovMA.Sprint3.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 5;
            int x = 2;

            double res = ds.GetMultiplySeries(x,startValue, stopValue);
            double wait = 208845;
            Assert.AreEqual(res, wait);
        }
    }
}