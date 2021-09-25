using System;
using System.Collections.Generic;

namespace LearningApp
{
    class Numbers
    {
        public void getMaxOccurance()
        {
            //Find occurance of integrs in given array
            Console.WriteLine("\n//Find occurance of integrs in given array\n");
            int[] arr = new int[] { 10, 20, 30, 10, 10, 20 };
            int len = arr.Length;
            System.Collections.Generic.Dictionary<int, int> d = new Dictionary<int, int>();
            for (int i = 0; i < len; i++)
            {
                if (d.ContainsKey(arr[i]))
                {
                    var val = d[arr[i]];
                    d.Remove(arr[i]);
                    d.Add(arr[i], val + 1);
                }
                else
                {
                    d.Add(arr[i], 1);
                }
            }
            foreach (KeyValuePair<int, int> m in d)
            {
                Console.WriteLine("\n" + m.Key + "-" + m.Value);
            }
        }
        // { 2, 202, 2, 3, 204, 4, 5, 203,207 };
        public void getSeries()
        {
            int[] series = new int[] { 2, 202, 2, 3, 204, 4, 5, 203, 206 };
            System.Collections.Generic.List<int> list = new List<int>();
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


        public void getLeader()
        {
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] a = new int[N]; //{12,2,4};
            for (int i = 0; i < N; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < N; j++)
            {
                int c = 1;
                for (int k = j + 1; k < N; k++)
                {
                    if (a[j] < a[k])
                    {
                        c = 0;
                        break;
                    }
                }
                if (c == 1)
                {
                    sum = sum + a[j];
                }
            }
            Console.Write(sum);
        }

        internal void getCrownNumber()
        {
            int N = 5;
            int[] a = { 20, 40, 10, 50, 30 };
            Console.Write("\n");
            int max = -1;
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                int value = a[i];
                if (i == 0 && value>a[i+1])
                {
                    max = max < a[i] ? a[i] : max;
                }
                if (i == N - 1 && value>a[i-1])
                {
                    max = max < a[i] ? a[i] : max;
                }
                if(i!=0 && i!=N-1 && value>a[i-1] && value>a[i+1])
                {
                    max = max < a[i] ? a[i] : max;
                }
            }
            Console.Write(max);
        }
        internal void matrix()
        {
            int[,] abc = { 
                {1,2 }, 
                {3,4 },
                {5,6 }
            };
            int _rows = 3;
            int _columns = 2;
            int k = 0;
            for (int i = 0; i < _rows; i++)
            { //00 01, 11,10
                //Console.Write("\n");
                if (k == 0)
                {
                    for (int j = 0; j < _columns; j++)
                    {
                        Console.Write(abc[i, j] + " ");// = int.Parse(Console.ReadLine());
                    }
                    k = 1;
                }
                else
                {
                    for (int j = _columns-1; j >=0; j--)
                    {
                        Console.Write(abc[i, j] + " ");// = int.Parse(Console.ReadLine());
                    }
                    k = 0;
                }
            }
        }
        internal void maxthree()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            // 1+2+3, 1+3+4, 1+4+5, 2+3+4, 2+4+5, 3+4+5
            int sum = 0;
            int max = -1;
            int count = 0;
            //Array.Sort(a); 
            for (int i = 0; i < a.Length - 2; i++)
            {
                for (int j = i + 1; j < a.Length - 1; j++)
                {
                    int n = a[i] + a[j] + a[j + 1];
                    max = n > max ? n : max;
                }
            }
            Console.Write(max);
        }
        internal void getSumList()
        {
            int[] list = new int[] { 10, 20, 30, 40, 50 };
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = i + 1; j < list.Length; j++)
                {
                    sum = sum + list[j];
                }
                Console.Write(sum + " ");
                sum = 0;
            }
        }
        public void getProductOfDigits(int num = 231)
        {
            int k = 1;
            while (num > 0)
            {
                k = k * num % 10;
                num = num / 10;
            }
        }
    }
}
