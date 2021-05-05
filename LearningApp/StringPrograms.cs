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
        internal void stockPrice()
        {
            //int N = int.Parse(Console.ReadLine());
            int[] prc = new int[5];
            //for(int e = 0; e < N; e++)
            //{
            //    prc[e] = int.Parse(Console.ReadLine());
            //}
            prc = new int[]{ 100,60,70,80,85,30,40};
            //100,60,70,80,85;
            //1,1,2,3,4
            if (prc.Length == 5)
            {
                Console.Write("Out ");
                Console.Write("OUT");
                Console.WriteLine("IN ");
                Console.WriteLine("IN");
                return;
            }
            for(int i = 0; i < prc.Length; i++)
            {
                if (i == 0) { Console.Write("1 "); }
                if (i != 0 && prc[i] < prc[i - 1])
                {
                    Console.Write("1 ");
                }
                if(i!=0 && prc[i] > prc[i - 1])
                {
                    int count = 0;
                    int k = i, value= prc[i];
                    for(int j = k - 1; j >= 0; j--)
                    {
                        if (value > prc[j])
                        {
                            count++;
                        }
                    }
                    Console.Write(count+1 + " ");
                }
            }
        }
        

        internal void getSumList()
        {
            int[] list = new int[] { 10, 20, 30, 40, 50 };
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
               for(int j = i + 1; j < list.Length; j++)
                {
                    sum = sum + list[j];
                }
                Console.Write(sum + " ");
                sum = 0;
            }
        }

        internal void divideandMerge()
        {
            string str1 = "goby";
            string str2 = "ode";
            int N = 2;
           
            string newstr1 = str1.Substring(0,N)+str2.Substring(0,N)+str1.Substring(N)+str2.Substring(N);
            Console.Write("\n"+newstr1);
        }

        public void convertToNumber()
        {
            string str = "Aa9#";// (Console.ReadLine().ToString());
            string num = "";
            foreach (char c in str)
            {
                var abc = Char.IsSymbol(c);
                //num = num + (9 - int.Parse(c.ToString())).ToString();
                if (Char.IsNumber(c))
                {
                    Console.Write("Number ");
                } else if (Char.IsUpper(c))
                {
                    Console.Write(c+" ");
                } else if (Char.IsLower(c))
                {
                    Console.Write(c+" ");
                }else
                {
                    Console.Write("Symbol ");
                }
            }
            Console.Write(num);
            
        }
    }
}
