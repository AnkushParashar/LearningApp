using System;
using System.Collections.Generic;
using System.Linq;

namespace LearningApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "ANKUSH";
            string nyName2 = "ANKUSH";
            string a = "MyName is ankush Parashar675853467";
            string[] names = new [] { "ABHISHEK", "ANJU", "ACHHAR" };
            List<string> abc = new List<string>();
            //Console.WriteLine(myName.CompareTo(nyName2));
            //Console.WriteLine(a.Replace("67", "").ToString());
            
            
            //STRINGS
            static string reverseString(string str)
            {
                string rev = "";
                int len = str.Length;
                for(int i = len - 1; i >= 0; i--)
                {
                    rev = rev + str[i];
                }
                return rev;
            }
            static int reverseNumber(int num)
            {
                int rev=0;
                //21


                return rev;
            }
            var entredString = (Console.ReadLine()).ToString();
            entredString = reverseString(entredString).ToString();
            Console.WriteLine("reverse sring is" + entredString);
            Console.ReadKey();
            
            //CREATING AND ARRAY
            int[,] arr= new int[,]{ {1,2 },{1,2 } };
            for(int i = 0; i <= arr.Length; i++)
            {
            } 
            

        }
    }
}
