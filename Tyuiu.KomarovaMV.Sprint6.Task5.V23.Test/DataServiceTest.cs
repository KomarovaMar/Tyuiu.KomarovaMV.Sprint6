using Tyuiu.KomarovaMV.Sprint6.Task5.V23.Lib;
namespace Tyuiu.KomarovaMV.Sprint6.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res = { -17, -14.32, -7.84, -1.57, -3.64, -13.26, -8.91, -17.77, -9, -1.49 - 7 };
            double[] res2 = ds.LoadFromDataFile(@"C:\Users\PC\Documents\InPutDataFileTask5V23.txt");
            CollectionAssert.AreEqual(res2, res);
        }
    }
}