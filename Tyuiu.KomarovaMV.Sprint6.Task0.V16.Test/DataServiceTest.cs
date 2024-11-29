using Tyuiu.KomarovaMV.Sprint6.Task0.V16.Lib;
namespace Tyuiu.KomarovaMV.Sprint6.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 4;
            double f=ds.Calculate(x);
            double res = 4.062;
            Assert.AreEqual(res, f);
        }
    }
}