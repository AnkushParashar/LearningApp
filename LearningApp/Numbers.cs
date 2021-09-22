using System;

namespace LearningApp
{
    class Numbers
    {
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
        internal void jj()
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
    }
}
