using System;
using System.Collections.Generic;

namespace LearningApp
{
    public class StringPrograms
    {
        public StringPrograms()
        {

        }
        // { 2, 202, 2, 3, 204, 4, 5, 203,207 };
        public void getSeries(int[] series)
        {
            List<int> list = new List<int>();
            int sum = 0;
            for(int i = 0; i < series.Length; i++)
            {
                sum = sum + (series[i]);
                if (i != series.Length - 1)
                {
                    if (series[i] > series[i + 1])
                    {
                        list.Add(sum);
                        sum = 0;
                    }
                }
                else
                {
                    list.Add(sum);
                }
            }
            int max = -1;
            foreach(int num in list)
            {
                if (num > max) {  max=num; }
            }
            Console.Write(max);
        }
    }
}
