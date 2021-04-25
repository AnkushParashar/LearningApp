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
            for (int i = 0; i < series.Length; i++)
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
            foreach (int num in list)
            {
                if (num > max) { max = num; }
            }
            Console.Write(max);
        }

        internal void StringProgram()
        {
            string input = "Morning";
            string target = "Bring";
            int add = 0, remove = 0, replace = 0;
            foreach (char ch in input)
            {
                if (!target.Contains(ch))
                {
                    input = input.Replace(ch.ToString(), "").ToString();
                    remove++;
                }
            }
            //rning
            foreach (char ch in input)
            {
                if (!target.Contains(ch))
                {
                }
            }
            foreach (char ch in input)
            {
                if (target.Contains(ch))
                {
                }
            }
        }

        internal void countMax1s()
        {
            string b = "101011000011";
            int N = 6;
            int max = -1;
            int count = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == '1')
                {
                    count++;
                }
                if (((i + 1) % N) == 0 || i == b.Length - 1)
                {
                    if (count > max)
                    {
                        max = count;
                    }
                    count = 0;
                }
            }
            Console.Write("\n COUNT>>>>" + max);
        }

        internal void numberOfBrackets()
        {
            int N = Convert.ToInt32("8");
            if (N % 2 == 0)
            {
                int n = N / 2;
                double k = Math.Pow(2, n - 1);
                Console.WriteLine(k);
            }
        }

        internal void findLengthfromStart()
        {
            string mixStr = "10Hellomynam";
            string num = "";
            foreach (char a in mixStr)
            {
                if (Char.IsNumber(a))
                {
                    num += a;
                }
            }
            mixStr = mixStr.Substring(num.Length);
            Console.Write(mixStr.Length == Convert.ToInt32(num));
        }

        public void getHSL()
        {
            string str = "SLH";
            int countAll = 0;
            for (int i = 0; i < str.Length; i++)
            {
                str = str.Substring(i);
                int countH = 0, countS = 0, countL = 0;
                foreach (char a in str)
                {
                    if (a == 'H')
                    {
                        countH++;
                    }
                    if (countH != 0 && a == 'S')
                    {
                        countS++;
                    }
                    if (countS != 0 && a == 'L')
                    {
                        countL++;
                        countAll++;
                        countH = 0; countS = 0; countL = 0;
                    }
                }
            }
            Console.Write("HSL>>>>>>>--"+countAll);
        }
    }
}
