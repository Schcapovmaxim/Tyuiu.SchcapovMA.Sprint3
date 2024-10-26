using Tyuiu.SchcapovMA.Sprint3.Task4.V26.Lib;
namespace Tyuiu.SchcapovMA.Sprint3.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidClaculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait =-1.924;
            Assert.AreEqual(res, wait);

        }
    }
}