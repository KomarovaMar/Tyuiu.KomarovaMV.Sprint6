using Tyuiu.KomarovaMV.Sprint6.Task2.V3.Lib;
namespace Tyuiu.KomarovaMV.Sprint6.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                DataService ds = new DataService();
                int x = -5;
                int y = 5;
                double[] res = { -12.18, 16.03, 18.87, 4.96, -9.99, -2.0, 2.16, -7.54, -22.76, -20.45,7.77 };
                CollectionAssert.AreEqual(res, ds.GetMassFunction(x, y));
            }

        }
    }
}