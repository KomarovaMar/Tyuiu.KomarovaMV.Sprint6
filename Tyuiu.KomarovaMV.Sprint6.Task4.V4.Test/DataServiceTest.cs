using Tyuiu.KomarovaMV.Sprint6.Task4.V4.Lib;
namespace Tyuiu.KomarovaMV.Sprint6.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = -5;
            int y = 5;
            double[] res = { 0.96, 1.32, 0.82, 0.44, 1.34, 0, -5.17, -3.69, -3.0, -2.38, -2.01 };
            CollectionAssert.AreEqual(res, ds.GetMassFunction(x, y));
        }
    }
}