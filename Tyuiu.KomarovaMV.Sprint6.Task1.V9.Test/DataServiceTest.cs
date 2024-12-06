using Tyuiu.KomarovaMV.Sprint6.Task1.V9.Lib;
namespace Tyuiu.KomarovaMV.Sprint6.Task1.V9.Test
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
            double[] res = { -19.62, -17.12, -18.15, -63.13, -24.92, -5.0, -1.46, 1.57, 6.38, 32.78, 225.11 };
            CollectionAssert.AreEqual(res,ds.GetMassFunction(x,y));
        }
    }
}