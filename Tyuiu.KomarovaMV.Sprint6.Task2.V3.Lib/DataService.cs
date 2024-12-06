using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KomarovaMV.Sprint6.Task2.V3.Lib
{
    public class DataService : ISprint6Task2V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            int c = 0;
            double[] result = new double[len];
            for (int i = startValue; i <= stopValue; i++)
            {
                result[c] = Math.Round(Math.Sin(i)/((double)i+1.2)+ Math.Cos(i)*7*(double)i-2, 2);
                if ((double)i + 1.2 == 0) { result[c] = 0; }
                c++;
            }
            return result;
        }
    }
}
