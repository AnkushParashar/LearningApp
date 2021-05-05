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
    }
}
