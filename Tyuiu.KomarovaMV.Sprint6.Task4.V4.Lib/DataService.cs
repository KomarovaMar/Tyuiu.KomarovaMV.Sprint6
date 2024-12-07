using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KomarovaMV.Sprint6.Task4.V4.Lib
{
    public class DataService : ISprint6Task4V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            int c = 0;
            double[] result = new double[len];
            for (int i = startValue; i <= stopValue; i++)
            {
                result[c] = Math.Round((2*(double)i-6)/(Math.Sin(i)+i)-3, 2);
                if (Math.Sin(i) + i == 0) { result[c] = 0; }
                c++;
            }
            return result;
        }
    }
}
