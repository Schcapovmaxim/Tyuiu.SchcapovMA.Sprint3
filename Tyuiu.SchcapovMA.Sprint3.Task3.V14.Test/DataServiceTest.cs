using Tyuiu.SchcapovMA.Sprint3.Task3.V14.Lib;
namespace Tyuiu.SchcapovMA.Sprint3.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharInString()
        {
            DataService ds = new DataService();
            string str = "dgt ghedd bed";
            string wait = "’gt ghe’’ be’";
            char chr1 = 'd';
            char chr2 = '’';
            string res = ds.ReplaceCharInString(str,chr1,chr2);
            Assert.AreEqual(wait, res);
        }
    }
}