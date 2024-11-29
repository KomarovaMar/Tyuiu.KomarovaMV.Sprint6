using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KomarovaMV.Sprint6.Task0.V16.Lib
{
    public class DataService : ISprint6Task0V16
    {
        public double Calculate(int x)
        {
            double res = Math.Round((1 + Math.Pow((double)x, 3)) / (Math.Pow((double)x, 2)), 3);
            return res;
        }
    }
}
