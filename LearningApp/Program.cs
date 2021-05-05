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
        static string Sortstring(string str)
        {
            string sorted="";
            char[] ar = str.ToCharArray();
            Array.Sort(ar);
            sorted = String.Join("", ar);

            return new string(ar);
        }
        static int reverseNumber(int num)
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
        static int sortNumber(int num)
        {
            string str = num.ToString();
            return int.Parse(Sortstring(str));
        }
        static void Main(string[] args)
        {

            string str= "mama";
            string rightmove = str[str.Length - 1] + str.Substring(0,str.Length-1);
            string leftmove = str.Substring(1)+str[0];
            if (rightmove.CompareTo(leftmove)==0) {
                Console.Write("matched");
            }

            //SORTING
            Console.WriteLine("\n//SORTING\n");
            string[] allNames = new string[] { "ABHISHEK", "ANJU", "ACHHAR" };
            //Console.WriteLine(myName.CompareTo(nyName2));
            //Console.WriteLine(a.Replace("67", "").ToString());

            //var entredString = (Console.ReadLine()).ToString();
            //entredString = reverseNumber(int.Parse(entredString)).ToString();
            //Console.WriteLine("reverse is\n" + entredString);

            Console.Write("after individual words sort\n");
            string[] newArray= new string[allNames.Length];
            for(int i = 0; i < allNames.Length; i++)
            {
                newArray[i] = Sortstring(allNames[i]);
                Console.Write(newArray[i] + " ");
            }
            Array.Sort(newArray);
            Array.Reverse(newArray);
            Console.Write("\nafter sort\n");
            foreach (string strg in newArray)
            {
                Console.Write(strg + " ");
            }

            //To find maximum occuring character in a string;
            Console.WriteLine("\n//To find maximum occuring character in a string;\n");
            string test = "testAnkushsssttt";
            int[] count = new int[256];
            foreach(char c in test)
            {
                count[c]++;
            }
            int max = -1;
            char result='-';
            foreach (char c in test)
            {
                if (count[c] > max)
                {
                    max = count[c];
                    result = c;
                }
            }
            Console.Write("\n"+result);

            //Find occurance of integrs in given array
            Console.WriteLine("\n//Find occurance of integrs in given array\n");
            int[] arr = new int[] { 10, 20, 30, 10, 10, 20 };
            int len = arr.Length;
            Dictionary<int, int> d = new Dictionary<int, int>();
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
                Console.WriteLine("\n"+m.Key + "-" + m.Value);
            }

            //Remove Duplicate from string
            Console.WriteLine("\n//Remove Duplicate from string\n");
            string inputStr = "aaabbccddeefghiijkkl";
            string newStr = "";
            Dictionary<char, int> mb = new Dictionary<char, int>();
            foreach(char ch in inputStr)
            {
                if(!newStr.Contains(ch))
                    newStr = newStr + ch;
            }
            Console.WriteLine(newStr);
            string newNewStr = "";
            foreach(char c in inputStr)
            {
                if (newNewStr.Contains(c))
                {
                    var val = mb[c];
                    mb.Remove(c);
                    mb.Add(c, val + 1);
                }
                else
                {
                    newNewStr = newNewStr + c;
                    mb.Add(c, 1);
                }
            }
            foreach(KeyValuePair<char,int> item in mb)
            {
                Console.WriteLine(" " +item.Key+ "-" +item.Value+ " ");
            }

            //SPLIT
            Console.Write("//SPLIT");
            string splitStr = "a quick brown fox jumps over the lazy dog";
            string[] abc = splitStr.Split(" ");

            //SERIES
            StringPrograms sp = new StringPrograms();
            int[] series = new int[] { 2, 202, 2, 3, 204, 4, 5,203,206 };
            //sp.getSeries(series);

            //STRINGS
            //sp.findLengthfromStart();
            //sp.numberOfBrackets();
            //sp.StringProgram();
            //sp.countMax1s();
            //sp.getHSL();
            //sp.stockPrice();
            //sp.getSumList();
            //sp.convertToNumber();
            sp.divideandMerge();

            Numbers nums = new Numbers();
            //nums.getLeader();
            //nums.getCrownNumber();
        }
    }
}
