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
            double[] res = { -2.15, -2.57, -3.0, -3.83, -11.7, 3.0, 2.19, 3.31, 2.97, 1.18, 0.03 };
            CollectionAssert.AreEqual(res, ds.GetMassFunction(x, y));
        }
    }
}