using System;
using System.Collections.Generic;

namespace LearningApp
{
    class Program
    {
        //STRINGS
        static string reverseString(string str)
        {
            string rev = "";
            int len = str.Length;
            for (int i = len - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            return rev;
        }
        public string Sortstring(string str)
        {
            string sorted="";
            char[] ar = str.ToCharArray();
            Array.Sort(ar);
            sorted = String.Join("", ar);

            return new string(ar);
        }
        public int reverseNumber(int num)
        {
            int rev = 0;
            //21
            while (num > 0)
            {
                int rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }

            return rev;
        }
        public int sortOneNumber(int num)
        {
            string str = num.ToString();
            return int.Parse(Sortstring(str));
        }
        static void Main(string[] a)
        {
            Numbers nums = new Numbers();
            StringPrograms sp = new StringPrograms();
            Console.Write("Enter program number: ");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                //STRINGS
                case 1: sp.sortingManupulations(); break;
                case 2: sp.getmaxOccurance(); break;
                case 3: sp.findLengthfromStart(); break;
                case 4: sp.numberOfBrackets(); break;
                case 5: sp.StringProgram(); break;
                case 6: sp.countMax1s(); break;
                case 7: sp.getHSL(); break;
                case 8: sp.stockPrice(); break;
                case 9: nums.getSumList(); break;
                case 10: sp.convertToNumber(); break;
                case 11: sp.divideandMerge(); break;

                //SERIES
                case 12: nums.getMaxOccurance(); break;
                case 13: nums.getSeries(); ; break;
                case 14: nums.getLeader(); break;
                case 15: nums.getCrownNumber(); break;
                case 16: nums.matrix(); break;
                case 17: nums.getProductOfDigits();break;
                case 18: nums.maxthree(); break;

                default:
                    return;
            }
        }
    }
}
