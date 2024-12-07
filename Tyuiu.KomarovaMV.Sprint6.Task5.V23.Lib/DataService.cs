﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KomarovaMV.Sprint6.Task5.V23.Lib
{
    public class DataService : ISprint6Task5V23
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    len++;
                }

            }
            double[] res = new double[len];
            int index = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    res[index]=Convert.ToDouble(line);
                    index++;
                }
            }
            res=res.Where(x => x < 0).ToArray();
            return res;

        }
    }
}