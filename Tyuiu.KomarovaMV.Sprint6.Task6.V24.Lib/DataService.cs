using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KomarovaMV.Sprint6.Task6.V24.Lib
{
    public class DataService : ISprint6Task6V24
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    res = res+ (line.Split(' ')[0])+" ";
                }
            }
            
            string result=res.TrimEnd(' ');
            return result;
        }
    }
}
