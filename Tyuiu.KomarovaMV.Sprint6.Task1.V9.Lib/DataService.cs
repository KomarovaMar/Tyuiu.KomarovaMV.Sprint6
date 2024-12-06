using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KomarovaMV.Sprint6.Task1.V9.Lib
{
    public class DataService : ISprint6Task1V9
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len=(stopValue-startValue)+1;
            int c = 0;
            double [] result = new double[len];
            for (int i = startValue; i <= stopValue; i++)
            {
                result[c] = Math.Round((2 * (double)i - 4 + ((2 * (double)i - 1) / (Math.Sin(i) + 1))), 2);
                if (i == 0) { result[c] = 0; }
                c++;
            }
            return result;
        }
    }
}
